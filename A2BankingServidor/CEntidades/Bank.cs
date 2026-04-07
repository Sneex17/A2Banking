namespace CEntidades
{
    public class Bank
    {
        public string Logo { get; set; } = 
            @"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingServidor\CPresentacion\Img\Icons\LOGO BANK.png";
        public string Nombre { get; set; } = "A2 Banking";
        public string Direccion { get; set; } = "Banco nacional de springfield";

        public string RutaDeposito { get; set; } =
            $@"C:\Users\xrami\OneDrive\Documentos\A2Banking\RecibosPDF\Depositos\RECIBO_DE_DEPOSITO_{DateTime.Now:yyyy-MM-dd_HH-mm-ss tt}.pdf";
        public string RutaTrasnferencias { get; set; } =
            $@"C:\Users\xrami\OneDrive\Documentos\A2Banking\RecibosPDF\Transferencias\RECIBO_DE_TRANSFERENCIA_{DateTime.Now:yyyy-MM-dd_HH-mm-ss tt}.pdf";
        public string RutaRetiro { get; set; } =
            $@"C:\Users\xrami\OneDrive\Documentos\A2Banking\RecibosPDF\Retiros\RECIBO_DE_RETIRO_{DateTime.Now:yyyy-MM-dd_HH-mm-ss tt}.pdf";
    }


}
