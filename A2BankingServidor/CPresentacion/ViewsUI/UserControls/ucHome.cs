using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CPresentacion.Plantillas;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucHome : UserControl
    {
        Usuario datosUsuario = new Usuario();
        public ucHome(Usuario usuario)
        {
            InitializeComponent();
            datosUsuario = usuario;
            CargarDatos(datosUsuario);
        }
        private void CargarDatos(Usuario usuario)
        {
            LbNombre.Text = datosUsuario.Nombre.ToUpper().ToString();
            LbRol.Text = datosUsuario.Rol.Nombre.ToString();
        }
        private void pbPerfil_Click(object sender, EventArgs e)
        {
            if (GroupbInfoPerfil.Visible == false)
            {
                GroupbInfoPerfil.Visible = true;
            }
            else
            {
                GroupbInfoPerfil.Visible = false;
            }
        }

        private void BuSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            var form = Application.OpenForms["MenuPrincipal"];

            if (form != null)
                form.Close();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.ToLongTimeString();
            LbFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
