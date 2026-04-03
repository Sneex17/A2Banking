namespace CEntidades
{
    public class Transferencia
    {
        public int TransferenciaId { get; set; }
        public int CuentaOrigenId { get; set; }
        public int CuentaDestinoId { get; set; }
        public decimal Monto { get; set; }
        public decimal Comision { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public decimal Balance { get; set; }
    }

}
