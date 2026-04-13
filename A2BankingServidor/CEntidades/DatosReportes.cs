namespace CEntidades
{
    public class DatosReportes
    {
        public string rutaGeneral { get; private set; } =
            @"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CDatos\DataSets\Cuentas\General\ReportesCuentasGeneral.rdlc";

        public string rutaDepositos { get; private set; } =
            @"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CDatos\DataSets\Servicios\Depositos\ReportesDepositos.rdlc";

        public string rutaRetiros { get; private set; } =
            @"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CDatos\DataSets\Servicios\Retiros\ReportesRetiros.rdlc";

        public string rutaTransferencias { get; private set; } =
            @"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CDatos\DataSets\Servicios\Transferencias\ReportesTransferencias.rdlc";
    }

}
