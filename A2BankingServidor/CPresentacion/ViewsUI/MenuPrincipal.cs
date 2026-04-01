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
        public MenuPrincipal(int rol)
        {
            InitializeComponent();
            Load += (s, e) => CargarHome();
            Load += (s, e) => ControlResposabilidades(rol);
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

        private void ControlResposabilidades(int rol)
        {
            switch (rol)
            {
                case 1:
                    {
                        tabpDepositos.Parent = null;
                        tabpRetiros.Parent = null;
                        tabpTranferencias.Parent = null;
                    }
                    break;
                case 2:
                    {
                        tabpClientes.Parent = null;
                        tabpCuentas.Parent = null;
                        tabpTranferencias.Parent = null;
                        tabpUsuarios.Parent = null;
                        tabpDepositos.Parent = null;
                    }
                    break;
                case 3:
                    {
                        tabpClientes.Parent = null;
                        tabpCuentas.Parent = null;
                        tabpUsuarios.Parent = null;
                    }
                    break;
                case 4:
                    {
                        tabpClientes.Parent = null;
                        tabpCuentas.Parent = null;
                        tabpTranferencias.Parent = null;
                        tabpUsuarios.Parent = null;
                        tabpRetiros.Parent = null;
                    }
                    break;

                default:
                    break;
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

            //Vista para las tranferencias
            if(controlMenuOpciones.SelectedTab == tabpTranferencias
                && tabpTranferencias.Controls.Count == 0)
            {
                ucTransferencias transferencias = new ucTransferencias();
                transferencias.Dock = DockStyle.Fill;
                tabpTranferencias.Controls.Add(transferencias);
            }
        }
    }
}
