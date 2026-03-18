using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.Plantillas;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucClientes : ucPlantilla
    {
        public ucClientes()
        {
            InitializeComponent();
        }

        private void BuBuscarPersonas_Click(object sender, EventArgs e)
        {
            fmPersonas personas = new fmPersonas();

            personas.SeleccionarPersona += (persona) =>
            {
                textbIdTitular.Text = persona.id.ToString();
                textbNombre.Text = persona.name.ToString();
                textbEdad.Text = persona.age.ToString();
                texbSexo.Text = persona.gender.ToString();
                textbOcupacion.Text = persona.occupation.ToString(); 
            };
            personas.ShowDialog();
        }
    }
}
