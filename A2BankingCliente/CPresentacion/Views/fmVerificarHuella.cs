using CEntidades;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Views
{
    public partial class fmVerificarHuella : Form, DPFP.Capture.EventHandler
    {
        public static bool Resultado { get; set; } = false;
        private Capture _capture;
        private byte[] _huellaGuardada;
        public fmVerificarHuella(byte[] huella)
        {
            InitializeComponent();
            _huellaGuardada = huella;
        }

        private void fmVerificarHuella_Load(object sender, EventArgs e)
        {
            IniciarLector();
        }

        private void fmVerificarHuella_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetenerLector();
        }

        // ──────────────────────────────────────────────────────────
        // Inicia la captura y queda en espera
        // ──────────────────────────────────────────────────────────
        private void IniciarLector()
        {
            try
            {
                _capture = new Capture();
                _capture.EventHandler = this;
                _capture.StartCapture();

                ActualizarEstado("🟡 Listo — coloque su dedo en el lector...", Color.Orange);
            }
            catch (Exception ex)
            {
                ActualizarEstado($"❌ Error al iniciar el lector: {ex.Message}", Color.Red);
            }
        }

        private void DetenerLector()
        {
            try
            {
                _capture?.StopCapture();
                _capture?.Dispose();
                _capture = null;
            }
            catch { }
        }

        // ──────────────────────────────────────────────────────────
        // SE DISPARA cuando el cliente pone el dedo → aquí verificas
        // ──────────────────────────────────────────────────────────
        public void OnComplete(object capture, string readerSerialNumber, Sample sample)
        {
            // Viene de un hilo del SDK → usar Invoke para tocar la UI
            this.Invoke(new Action(() =>
            {
                ActualizarEstado("🔄 Procesando huella...", Color.Blue);
            }));


            try
            {
                // 1. Extraer características de la muestra capturada
                FeatureSet caracteristicas = ExtraerCaracteristicas(sample);

                if (caracteristicas == null)
                {
                    this.Invoke(new Action(() =>
                        ActualizarEstado("⚠ Calidad insuficiente. Intente de nuevo...", Color.Orange)));
                    return; // El lector sigue activo → puede reintentar
                }

                // 2. Deserializar el template guardado en BD
                DPFP.Template templateGuardado = DeserializarTemplate(_huellaGuardada);

                // 3. Comparar
                var verificador = new DPFP.Verification.Verification();
                var resultadoVerif = new DPFP.Verification.Verification.Result();
                verificador.Verify(caracteristicas, templateGuardado, ref resultadoVerif);

                Resultado = resultadoVerif.Verified;
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                    ActualizarEstado($"❌ Error: {ex.Message}", Color.Red)));
                return;
            }

            // 4. Mostrar resultado en UI
            this.Invoke(new Action(() =>
            {
                var img = new Recursos();
                if (Resultado)
                {
                    ActualizarEstado("✔ Huella verificada correctamente.", Color.Green);

                    pbResultado.Image = Image.FromFile(img.RutaImgCheckTrue);
                }
                else
                {
                    ActualizarEstado("✘ Huella NO coincide. Intente de nuevo...", Color.Red);
                    // El lector sigue activo → el cliente puede volver a intentar
                    pbResultado.Image = Image.FromFile(img.RutaImgCheckFalse);
                }
            }));
        }

        // ──────────────────────────────────────────────────────────
        // Eventos del SDK que debes implementar
        // ──────────────────────────────────────────────────────────
        public void OnFingerTouch(object capture, string readerSerialNumber)
        {
            this.Invoke(new Action(() =>
                ActualizarEstado("👆 Dedo detectado...", Color.Blue)));
        }

        public void OnFingerGone(object capture, string readerSerialNumber)
        {
            this.Invoke(new Action(() =>
                ActualizarEstado("🟡 Coloque su dedo en el lector...", Color.Orange)));
        }

        public void OnReaderConnect(object capture, string readerSerialNumber)
        {
            this.Invoke(new Action(() =>
                ActualizarEstado("🟡 Lector conectado. Coloque su dedo...", Color.Orange)));
        }

        public void OnReaderDisconnect(object capture, string readerSerialNumber)
        {
            this.Invoke(new Action(() =>
                ActualizarEstado("❌ Lector desconectado.", Color.Red)));
        }

        public void OnSampleQuality(object capture, string readerSerialNumber, CaptureFeedback feedback)
        {
            if (feedback != CaptureFeedback.Good)
            {
                this.Invoke(new Action(() =>
                    ActualizarEstado("⚠ Mala calidad, ajuste el dedo...", Color.DarkOrange)));
            }
        }

        // ──────────────────────────────────────────────────────────
        // Helpers
        // ──────────────────────────────────────────────────────────
        private FeatureSet ExtraerCaracteristicas(Sample muestra)
        {
            var extractor = new FeatureExtraction();
            var captureFeedback = CaptureFeedback.None;
            var featureSet = new FeatureSet();

            extractor.CreateFeatureSet(muestra, DataPurpose.Verification, ref captureFeedback, ref featureSet);

            return (captureFeedback == CaptureFeedback.Good) ? featureSet : null;
        }

        private DPFP.Template DeserializarTemplate(byte[] bytes)
        {
            var template = new DPFP.Template();
            using (var ms = new MemoryStream(bytes))
            {
                template.DeSerialize(ms);
            }
            return template;
        }

        // Actualiza un Label llamado lblEstado en tu form
        private void ActualizarEstado(string mensaje, Color color)
        {
            lbEstados.Text = mensaje;
            lbEstados.ForeColor = color;
        }
    }
}
