namespace CEntidades
{
    public class Sonido
    {
        public string ruta { get; set; } 

        public static string GetSonido()
        {
            Sonido sonido = new Sonido();
            sonido.ruta = @"C:\Users\xrami\OneDrive\Documentos\A2Banking\A2BankingCliente\CPresentacion\media\Audio boton.wav";
            return sonido.ruta;
        }
    }
}
