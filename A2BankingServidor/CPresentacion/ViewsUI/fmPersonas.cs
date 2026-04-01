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
    public partial class fmPersonas : Form
    {
        public event Action<Persona> SeleccionarPersona;
        public fmPersonas()
        {
            InitializeComponent();
            DecorarDatagrid();
            ListaPersona();
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
        private async void ListaPersona()
        {
            var lista = await GetPersonasServicio.GetPersonas();
            DatosFiltro(lista);
        }

        private void DatosFiltro(List<Persona> personas)
        {
            foreach (var persona in personas)
            {
                if (persona.status == "Alive" && persona.age != null)
                {
                    viewData.Rows.Add(new object[]
                    {
                        Convert.ToString(persona.id), persona.name,
                        Convert.ToString(persona.age), (persona.gender == "Male") ? "M" : "F",
                        persona.occupation
                    });
                }
            }
        }

        private void viewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var persona = new Persona()
                {
                    id = Convert.ToInt32(viewData.Rows[e.RowIndex].Cells["Id"].Value),
                    name = viewData.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    age = Convert.ToInt32(viewData.Rows[e.RowIndex].Cells["Edad"].Value),
                    gender = viewData.Rows[e.RowIndex].Cells["Sexo"].Value.ToString(),
                    occupation = viewData.Rows[e.RowIndex].Cells["Ocupacion"].Value.ToString()
                };
                SeleccionarPersona?.Invoke(persona);
                this.Close(); 
            }
        }
    }
}
