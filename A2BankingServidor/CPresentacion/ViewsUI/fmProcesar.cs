using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.ViewsUI
{
    public partial class fmProcesar : Form
    {
        public fmProcesar(string service)
        {
            InitializeComponent();
            InicarProceso(service);
        }

        private void fmProcesar_Load(object sender, EventArgs e)
        {
            pbImg.Image = Image.FromFile(@"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CPresentacion\Img\Videos\Cargando.gif");
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private async void InicarProceso(string servicio)
        {
            for (int i = 2; i >= 0; i--)
            {
                labelTexto.Text = $"Procesando {servicio}";
                await Task.Delay(1000);
                LbTime.Text = $"Tiempo restante {i}".ToString();
            }
            await Task.Delay(500);
            this.Hide();
        }
    }
}
