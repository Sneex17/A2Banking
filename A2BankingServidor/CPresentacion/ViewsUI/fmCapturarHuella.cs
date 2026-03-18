using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CPresentacion.ViewsUI
{
    public partial class fmCapturarHuella : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture _capture;
        private Enrollment _enrollment;
        private bool _enrollmentCompleto = false;
        public string TemplateBase64 { get; private set; }

        public fmCapturarHuella()
        {
            InitializeComponent();
        }

        private void BuIniciar_Click(object sender, EventArgs e)
        {
            _enrollment = new Enrollment();
            barraProbreso.Value = 0;
            BuIniciar.Enabled = false;
            lbEstados.Text = "Coloque el dedo en el sensor...";

            _capture = new DPFP.Capture.Capture();
            _capture.EventHandler = this;   // El mismo form maneja los eventos
            _capture.StartCapture();
        }

        public void OnComplete(object capture, string reader, Sample sample)
        {
            // 1. Pausar captura para obligar a retirar el dedo
            _capture.StopCapture();

            // 2. Mostrar imagen
            var conversor = new SampleConversion();
            Bitmap imagen = null;
            conversor.ConvertToPicture(sample, ref imagen);
            if (imagen != null)
                Invoke(new Action(() => pbImagenHuella.Image = imagen));

            // 3. Extraer características
            var extractor = new FeatureExtraction();
            var feedback = CaptureFeedback.None;
            var features = new FeatureSet();
            extractor.CreateFeatureSet(sample, DataPurpose.Enrollment, ref feedback, ref features);

            if (feedback != CaptureFeedback.Good)
            {
                ActualizarEstado("Calidad baja. Intente de nuevo.");
                _capture.StartCapture();
                return;
            }

            // 4. Agregar muestra al enrollment
            try
            {
                _enrollment.AddFeatures(features);
            }
            catch (Exception)
            {
                _enrollment = new Enrollment();
                Invoke(new Action(() =>
                {
                    barraProbreso.Value = 0;
                    BuIniciar.Enabled = true;
                }));
                ActualizarEstado("⚠ Dedo diferente. Inicie de nuevo con el mismo dedo.");
                return;
            }

            // 5. Verificar si el SDK detectó dedo diferente
            if (_enrollment.TemplateStatus == Enrollment.Status.Failed)
            {
                _enrollment = new Enrollment();
                Invoke(new Action(() =>
                {
                    barraProbreso.Value = 0;
                    BuIniciar.Enabled = true;
                }));
                ActualizarEstado("⚠ Dedo diferente. Inicie de nuevo con el mismo dedo.");
                return;
            }

            // 6. Actualizar progreso
            int tomadas = 4 - (int)_enrollment.FeaturesNeeded;
            Invoke(new Action(() => barraProbreso.Value = tomadas * 25));
            Invoke(new Action(() => lbCantidadMuestras.Text = $"Muestra {tomadas} de 4"));

            // 7. ¿Ya están las 4 muestras?
            if (_enrollment.TemplateStatus == Enrollment.Status.Ready)
            {
                _enrollmentCompleto = true;

                // Serializar a Base64
                var stream = new MemoryStream();
                _enrollment.Template.Serialize(stream);
                TemplateBase64 = Convert.ToBase64String(stream.ToArray());

                _capture.Dispose();

                Invoke(new Action(() =>
                {
                    barraProbreso.Value = 100;
                    lbEstados.Text = "✔ Huella lista. Puede continuar.";
                }));
            }
            else
            {
                ActualizarEstado($"Muestra {tomadas} de 4. Retire y vuelva a colocar el dedo.");
                _capture.StartCapture();
            }
        }

        public void OnFingerTouch(object capture, string reader)
        {
            if (!_enrollmentCompleto)
                ActualizarEstado("Dedo detectado...");
        }

        public void OnFingerGone(object capture, string reader)
        {
            if (!_enrollmentCompleto)
                ActualizarEstado("Retire el dedo y vuelva a colocar.");
        }

        public void OnReaderConnect(object capture, string reader)
            => ActualizarEstado("Lector conectado.");

        public void OnReaderDisconnect(object capture, string reader)
            => ActualizarEstado("⚠ Lector desconectado.");

        public void OnSampleQuality(object capture, string reader, CaptureFeedback feedback)
        {
            // Solo notifica si la calidad es mala, el caso Good ya lo maneja OnComplete
            if (feedback != CaptureFeedback.Good)
                ActualizarEstado("Calidad baja, intente de nuevo.");
        }

        // ── Helper ──────────────────────────────────────────────
        private void ActualizarEstado(string mensaje)
        {
            if (lbEstados.InvokeRequired)
                Invoke(new Action(() => lbEstados.Text = mensaje));
            else
                lbEstados.Text = mensaje;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _capture?.StopCapture();
            _capture?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
