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
using CEntidades;

namespace CPresentacion.ViewsUI.UserControls
{
    public partial class ucReportes : UserControl
    {
        private DatosReportes _datosReportes;
        private DateTime FechaInicio, FechaFin;
        public ucReportes()
        {
            InitializeComponent();
            _datosReportes = new DatosReportes();
            CargarFormato();
        }
        private void CargarFormato()
        {
            dateTimeInicio.CustomFormat = "dd/mm/yyyy HH:mm:ss";
            dateTimeFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
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
            reportViewer.LocalReport.ReportPath = _datosReportes.rutaGeneral;
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
            reportViewer.LocalReport.ReportPath = _datosReportes.rutaGeneral;
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
            reportViewer.LocalReport.ReportPath = _datosReportes.rutaGeneral;
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
            reportViewer.LocalReport.ReportPath = _datosReportes.rutaGeneral;
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetCuentasGeneral", dataSet.spVerRCuentaCanceladas.DefaultView));
            this.reportViewer.RefreshReport();
        }

        private void BuDepositos_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSet = ReportesA2Banking.ReporteDepositos();
                var lista = ReportesA2Banking.ReportesDepositosTableAdapter();
                var tabla = ReportesA2Banking.TablaReportesDepositos();

                if (rbYesFecha.Checked == true)
                {
                    FechaInicio = dateTimeInicio.Value;
                    FechaFin = dateTimeFin.Value;

                    EvaluarFechas(FechaInicio, FechaFin);
                    lista.Fill(dataSet.spReportesDepositos, FechaInicio, FechaFin);
                }
                else
                {
                    lista.Fill(dataSet.spReportesDepositos, null, null);
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.ReportPath = _datosReportes.rutaDepositos;
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DsReportesDepositos", dataSet.spReportesDepositos.DefaultView));
                this.reportViewer.RefreshReport();
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuRetiros_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSet = ReportesA2Banking.ReporteRetiros();
                var lista = ReportesA2Banking.ReportesRetirosTableAdapter();
                var tabla = ReportesA2Banking.TablaReportesRetiros();

                if (rbYesFecha.Checked == true)
                {
                    FechaInicio = dateTimeInicio.Value;
                    FechaFin = dateTimeFin.Value;

                    EvaluarFechas(FechaInicio, FechaFin);
                    lista.Fill(dataSet.spReportesRetiros, FechaInicio, FechaFin);
                }
                else
                {
                    lista.Fill(dataSet.spReportesRetiros, null, null);
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.ReportPath = _datosReportes.rutaRetiros;
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DsReportesRetiros", dataSet.spReportesRetiros.DefaultView));
                this.reportViewer.RefreshReport();
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuTransferencias_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSet = ReportesA2Banking.ReporteTransferencias();
                var lista = ReportesA2Banking.ReportesTransferenciasTableAdapter();
                var tabla = ReportesA2Banking.TablaReportesTransferencias();

                if (rbYesFecha.Checked == true)
                {
                    FechaInicio = dateTimeInicio.Value;
                    FechaFin = dateTimeFin.Value;

                    EvaluarFechas(FechaInicio, FechaFin);
                    lista.Fill(dataSet.spReportesTransferencias, FechaInicio, FechaFin);
                }
                else
                {
                    lista.Fill(dataSet.spReportesTransferencias, null, null);
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.ReportPath = _datosReportes.rutaTransferencias;
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DsReportesTransferencias", dataSet.spReportesTransferencias.DefaultView));
                this.reportViewer.RefreshReport();
            }
            catch (ControlExcepciones error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rbYesFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesFecha.Checked == true)
            {
                LbFechaInicio.Visible = true;
                LbFechaFin.Visible = true;
                dateTimeInicio.Visible = true;
                dateTimeFin.Visible = true;
            }
            else
            {
                LbFechaInicio.Visible = false;
                LbFechaFin.Visible = false;
                dateTimeInicio.Visible = false;
                dateTimeFin.Visible = false;
            }
        }
        private void EvaluarFechas(DateTime Inicio, DateTime Fin)
        {
            if (Inicio > Fin)
            {
                throw new ControlExcepciones($"La fecha de inicio debe ser menor a la fecha de fin\nFecha de Inicio {FechaInicio}\nFecha de Fin {FechaFin}");
            }
        }
    }
}
