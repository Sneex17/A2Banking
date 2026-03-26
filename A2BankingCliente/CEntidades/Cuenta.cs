namespace CEntidades
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public Banco Banco { get; set; }
        public int TitularId { get; set; }
        public string Nombre { get; set; }
        public int NumeroCuenta { get; set; }
        public decimal Balance { get; set; }
        public int CodigoPin { get; set; }
        public byte[] CodigoHuella { get; set; }
    }
}
