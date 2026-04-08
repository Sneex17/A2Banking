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
    public partial class fmBienvenida : Form
    {
        string Nombre = string.Empty;
        public fmBienvenida(string nombre)
        {
            InitializeComponent();
            Nombre = nombre;
        }

        private void fmBienvenida_Load(object sender, EventArgs e)
        {
            pbImg.Image = Image.FromFile(@"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CPresentacion\Img\Videos\Saludo.gif");
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            LbNombre.Text = Nombre.ToString();
        }
    }
}
