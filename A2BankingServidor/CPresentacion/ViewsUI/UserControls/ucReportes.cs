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
using CNegocio;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucReportes : UserControl
    {
        string ruta = @"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CDatos\DataSets\Cuentas\General\ReportesCuentasGeneral.rdlc";
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
            if (panelReportesCuentas.Visible == true)
            {
                panelReportesCuentas.Visible = false;
            }
            if (panelReportesServicios.Visible == true)
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

        private void BuCuentasGeneral_Click(object sender, EventArgs e)
        {
            var dataSet = ReportesA2Banking.ReporteCuentasGeneral();
            var lista = ReportesA2Banking.ReporteCuentasGeneralAdapter();
            var tabla = ReportesA2Banking.TablaCuentasGeneral();

            lista.Fill(dataSet.spVerRCuentaGeneral);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportPath = ruta;
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetCuentasGeneral", dataSet.spVerRCuentaGeneral.DefaultView));
            this.reportViewer.RefreshReport();
        }

        private void BuCuentasActivas_Click(object sender, EventArgs e)
        {
            var dataSet = ReportesA2Banking.ReporteCuentasActivas();
            var lista = ReportesA2Banking.ReporteCuentasActivasAdapter();
            var tabla = ReportesA2Banking.TablaCuentasActivas();

            lista.Fill(dataSet.spVerRCuentaActivas);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportPath = ruta;
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetCuentasGeneral", dataSet.spVerRCuentaActivas.DefaultView));
            this.reportViewer.RefreshReport();
        }

        private void BuCuentasInactivas_Click(object sender, EventArgs e)
        {
            var dataSet = ReportesA2Banking.ReporteCuentasInactivas();
            var lista = ReportesA2Banking.ReporteCuentasInactivasAdapter();
            var tabla = ReportesA2Banking.TablaCuentasInactivas();

            lista.Fill(dataSet.spVerRCuentaInactivas);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportPath = ruta;
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetCuentasGeneral", dataSet.spVerRCuentaInactivas.DefaultView));
            this.reportViewer.RefreshReport();
        }

        private void BuCuentasCanceladas_Click(object sender, EventArgs e)
        {
            var dataSet = ReportesA2Banking.ReporteCuentasCanceladas();
            var lista = ReportesA2Banking.ReporteCuentasCanceladasAdapter();
            var tabla = ReportesA2Banking.TablaCuentasCanceladas();

            lista.Fill(dataSet.spVerRCuentaCanceladas);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportPath = ruta;
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetCuentasGeneral", dataSet.spVerRCuentaCanceladas.DefaultView));
            this.reportViewer.RefreshReport();
        }
    }
}
