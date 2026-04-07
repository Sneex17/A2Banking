using CInfraestructura.EnviarGmail;
using CNegocio;
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
    public partial class fmCorreo : Form
    {
        string code = "";
        bool valido = false;
        public string correo { get; set; }
        public fmCorreo()
        {
            InitializeComponent();
        }

        private void BuSendCode_Click(object sender, EventArgs e)
        {
            code = LogicaNegocio.ValidarCorreo(textbCorreo.Text);

        }

        private void BuConfirmar_Click(object sender, EventArgs e)
        {
            var respuesta = LogicaNegocio.CorreoListo(textbCodigo.Text, code);

            if (!respuesta)
            {
                lbMensaje.Visible = true;
                lbMensaje.ForeColor = Color.Red;
                lbMensaje.Text = "Código invalido";
            }
            else
            {
                lbMensaje.Visible = true;
                valido = respuesta;
                lbMensaje.ForeColor = Color.Green;
                lbMensaje.Text = "Correo validado";
            }
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            if(valido)
            {
                correo = textbCorreo.Text;
                this.Close();
            }
            else
            {
                lbMensaje.Visible = true;
                lbMensaje.ForeColor = Color.Red;
                lbMensaje.Text = "Debe de validar su correo";
            }
            
        }
    }
}
