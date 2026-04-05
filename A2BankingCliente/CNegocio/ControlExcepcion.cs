namespace CNegocio
{
    public class  ControlExcepcion : Exception
    {
        public ControlExcepcion() { }
        public ControlExcepcion(string mensaje) : base (mensaje ){ }
      
    }
}
