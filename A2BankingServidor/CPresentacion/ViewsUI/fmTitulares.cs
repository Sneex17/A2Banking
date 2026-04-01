using CEntidades;
using CNegocio;
using CPresentacion.DecoratorPattern;
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
    public partial class fmTitulares : Form
    {
        public event Action<Titular> SeleccionarTitular;
        public fmTitulares()
        {
            InitializeComponent();
            CargarDatos();
            DecorarDatagrid();
        }
        private void DecorarDatagrid()
        {
            IDataGridDecorator estilo = new BordeDecorator(
                            new SeleccionDecorator(
                            new FilasAlternasDecorator(
                            new HeaderDecorator(
                            new DataGridBase()))));
            estilo.Aplicar(viewData);
        }
        private void CargarDatos()
        {
            viewData.DataSource = LogicaNegocio.ListaTitulares();
        }

        private void viewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var titular = new Titular()
                {
                    TitularId = Convert.ToInt32(viewData.Rows[e.RowIndex].Cells["TitularId"].Value),
                    Nombre = viewData.Rows[e.RowIndex].Cells["Nombre"].Value.ToString()
                };
                SeleccionarTitular?.Invoke(titular);
                this.Close();
            }
        }
    }
}
