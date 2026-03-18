using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.ViewsUI.UserControls;

namespace CPresentacion.ViewsUI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Load += (s, e) => CargarHome();
        }

        private void CargarHome()
        {
            if (controlMenuOpciones.SelectedTab == tabpHome
                && tabpHome.Controls.Count == 0)
            {
                ucHome home = new ucHome();
                home.Dock = DockStyle.Fill;
                tabpHome.Controls.Add(home);
            }
        }
        private void controlMenuOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vista de los clientes
            if(controlMenuOpciones.SelectedTab == tabpClientes 
                && tabpClientes.Controls.Count == 0)
            {
                ucClientes clientes = new ucClientes();
                clientes.Dock = DockStyle.Fill;
                tabpClientes.Controls.Add(clientes);
            }

            //Vista de los usuarios
            if (controlMenuOpciones.SelectedTab == tabpUsuarios 
                && tabpUsuarios.Controls.Count == 0)
            {
                ucUsuarios usuarios = new ucUsuarios();
                usuarios.Dock = DockStyle.Fill;
                tabpUsuarios.Controls.Add(usuarios);
            }
        }
    }
}
