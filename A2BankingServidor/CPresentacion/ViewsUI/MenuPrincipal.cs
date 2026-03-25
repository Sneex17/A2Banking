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

            //Vista de las cuentas
            if(controlMenuOpciones.SelectedTab == tabpCuentas 
                && tabpCuentas.Controls.Count == 0)
            {
                ucCuentas cuentas = new ucCuentas();
                cuentas.Dock = DockStyle.Fill;
                tabpCuentas.Controls.Add(cuentas);
            }

            //Vista para los dépositos
            if(controlMenuOpciones.SelectedTab == tabpDepositos
                && tabpDepositos.Controls.Count == 0)
            {
                ucDepositos depositos = new ucDepositos();
                depositos.Dock = DockStyle.Fill;
                tabpDepositos.Controls.Add(depositos);
            }

            //Vista para los retiros
            if(controlMenuOpciones.SelectedTab == tabpRetiros
                && tabpRetiros.Controls.Count == 0)
            {
                ucRetiros retiros = new ucRetiros();
                retiros.Dock = DockStyle.Fill;
                tabpRetiros.Controls.Add(retiros);
            }
        }
    }
}
