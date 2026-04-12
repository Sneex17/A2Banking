using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucReportes : UserControl
    {
        public ucReportes()
        {
            InitializeComponent();
        }

        private void ucReportes_Load(object sender, EventArgs e)
        {
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(reportViewer);
        }
        private void HideSubMenu()
        {
            if(panelReportesCuentas.Visible == true)
            {
                panelReportesCuentas.Visible = false;
            }
            if(panelReportesServicios.Visible == true)
            {
                panelReportesServicios.Visible = false;
            }
        }
        private void controlSubMenu(Panel panelSubMenu)
        {
            HideSubMenu();
            if (panelSubMenu.Visible == false)
            {
                panelSubMenu.Visible = true;
            }
            else
            {
                panelSubMenu.Visible = false;
            }
        }
        private void BuCuentas_Click(object sender, EventArgs e)
        {
            controlSubMenu(panelReportesCuentas);
        }

        private void BuReportesServicios_Click(object sender, EventArgs e)
        {
            controlSubMenu(panelReportesServicios);
        }
    }
}
