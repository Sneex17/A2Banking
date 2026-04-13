namespace CEntidades
{
    public class Retiro
    {
        public int RetiroId { get; set; }
        public int CuentaId { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
    }

}
