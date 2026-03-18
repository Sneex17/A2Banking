using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;
using CPresentacion.Plantillas;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucUsuarios : ucPlantilla
    {
        public ucUsuarios()
        {
            InitializeComponent();
            CargarComponentes();
        }

        private void CargarComponentes()
        {
            comboRoles.DataSource = LogicaNegocio.ListaRoles();
            comboRoles.ValueMember = "RolId";
            comboRoles.DisplayMember = "Nombre";
        }
    }
}
