using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CPresentacion.ViewsUI
{
    public partial class fmCodigoPin : Form
    {
        public static string CodigoPIN {  get; private set; }
        public fmCodigoPin()
        {
            InitializeComponent();
        }

        private void BuVerPin_Click(object sender, EventArgs e)
        {
            if (BuVerPin.IconChar == IconChar.Eye)
            {
                textbPin.UseSystemPasswordChar = false;
                textbPinConfirmacion.UseSystemPasswordChar = false;
                BuVerPin.IconChar = IconChar.EyeSlash;
            }
            else
            {
                textbPin.UseSystemPasswordChar = true;
                textbPinConfirmacion.UseSystemPasswordChar = true;
                BuVerPin.IconChar = IconChar.Eye;
            }
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textbPin.Text))
            {
                Excepciones("Debe ingresar un código PIN");
            }
            else if (string.IsNullOrWhiteSpace(textbPinConfirmacion.Text))
            {
                Excepciones("Debe confirmar su código PIN");
            }
            else if (textbPin.Text != textbPinConfirmacion.Text)
            {
                Excepciones("El código PIN no coincide");
            }
            else if (textbPin.Text.Length < 3)
            {
                Excepciones("El código PIN debe tener al menos 4 digitos");
            }
            else
            {
                CodigoPIN = textbPin.Text;
                this.Close();
            }
        }
        private void Excepciones(string mensaje)
        {
            lbMensaje.Visible = true;
            lbMensaje.ForeColor = Color.IndianRed;
            lbMensaje.Text = mensaje;
        }
    }
}
