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
    public partial class ucCuentas : ucPlantilla
    {
        public ucCuentas()
        {
            InitializeComponent();
        }

        private void BuCapturarHuella_Click(object sender, EventArgs e)
        {
            fmCapturarHuella capturarHuella = new fmCapturarHuella();
            capturarHuella.ShowDialog();

            if (!string.IsNullOrEmpty(capturarHuella.TemplateBase64))
                textbHuella.Text = capturarHuella.TemplateBase64;
        }
    }
}
