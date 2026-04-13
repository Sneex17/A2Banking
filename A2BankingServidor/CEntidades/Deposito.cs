namespace CEntidades
{
    public class Deposito
    {
        public int DepositoId { get; set; }
        public int CuentaId { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
    }

}
