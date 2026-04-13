using CDatos.DataSets.Cuentas.General;
using CDatos.DataSets.Cuentas.General.DsCuentasActivasTableAdapters;
using CDatos.DataSets.Cuentas.General.DsCuentasCanceladasTableAdapters;
using CDatos.DataSets.Cuentas.General.DsCuentasGeneralTableAdapters;
using CDatos.DataSets.Cuentas.General.DsCuentasInactivasTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.DataSets.Servicios.Depositos;
using CDatos.DataSets.Servicios.Depositos.DsDepositosTableAdapters;
using CDatos.DataSets.Servicios.Retiros;
using CDatos.DataSets.Servicios.Retiros.DsRetirosTableAdapters;
using CDatos.DataSets.Servicios.Transferencias;
using CDatos.DataSets.Servicios.Transferencias.DsTransferenciasTableAdapters;

namespace CNegocio
{
    public class ReportesA2Banking
    {
        //Datos reportes general de las cuentas
        public static DsCuentasGeneral ReporteCuentasGeneral()
        {
            return new DsCuentasGeneral();
        }
        public static spVerRCuentaGeneralTableAdapter ReporteCuentasGeneralAdapter()
        {
            return new spVerRCuentaGeneralTableAdapter();
        }
        public static DsCuentasGeneral.spVerRCuentaGeneralDataTable TablaCuentasGeneral()
        {
            return new DsCuentasGeneral.spVerRCuentaGeneralDataTable();
        }

        //Datos reportes de las cuentas activas
        public static DsCuentasActivas ReporteCuentasActivas()
        {
            return new DsCuentasActivas();
        }
        public static spVerRCuentaActivasTableAdapter ReporteCuentasActivasAdapter()
        {
            return new spVerRCuentaActivasTableAdapter();
        }
        public static DsCuentasActivas.spVerRCuentaActivasDataTable TablaCuentasActivas()
        {
            return new DsCuentasActivas.spVerRCuentaActivasDataTable();
        }

        //Datos reportes de las cuentas inactivas
        public static DsCuentasInactivas ReporteCuentasInactivas()
        {
            return new DsCuentasInactivas();
        }
        public static spVerRCuentaInactivasTableAdapter ReporteCuentasInactivasAdapter()
        {
            return new spVerRCuentaInactivasTableAdapter();
        }
        public static DsCuentasInactivas.spVerRCuentaInactivasDataTable TablaCuentasInactivas()
        {
            return new DsCuentasInactivas.spVerRCuentaInactivasDataTable();
        }

        //Datos reportes de las cuentas canceladas
        public static DsCuentasCanceladas ReporteCuentasCanceladas()
        {
            return new DsCuentasCanceladas();
        }
        public static spVerRCuentaCanceladasTableAdapter ReporteCuentasCanceladasAdapter()
        {
            return new spVerRCuentaCanceladasTableAdapter();
        }
        public static DsCuentasCanceladas.spVerRCuentaCanceladasDataTable TablaCuentasCanceladas()
        {
            return new DsCuentasCanceladas.spVerRCuentaCanceladasDataTable();
        }


        //Datos reportes de dépositos
        public static DsDepositos ReporteDepositos()
        {
            return new DsDepositos();
        }
        public static spReportesDepositosTableAdapter ReportesDepositosTableAdapter()
        {
            return new spReportesDepositosTableAdapter();
        }
        public static DsDepositos.spReportesDepositosDataTable TablaReportesDepositos()
        {
            return new DsDepositos.spReportesDepositosDataTable();
        }

        //Datos reportes de retiros
        public static DsRetiros ReporteRetiros()
        {
            return new DsRetiros();
        }
        public static spReportesRetirosTableAdapter ReportesRetirosTableAdapter()
        {
            return new spReportesRetirosTableAdapter();
        }
        public static DsRetiros.spReportesRetirosDataTable TablaReportesRetiros()
        {
            return new DsRetiros.spReportesRetirosDataTable();
        }

        //Datos reportes de transferencias
        public static DsTransferencias ReporteTransferencias()
        {
            return new DsTransferencias();
        }
        public static spReportesTransferenciasTableAdapter ReportesTransferenciasTableAdapter()
        {
            return new spReportesTransferenciasTableAdapter();
        }
        public static DsTransferencias.spReportesTransferenciasDataTable TablaReportesTransferencias()
        {
            return new DsTransferencias.spReportesTransferenciasDataTable();
        }

    }
}
