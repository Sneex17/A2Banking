using Microsoft.Extensions.Configuration;

namespace CDatos
{
    public class ConexionAppDB
    {
        private static IConfiguration? _configuration;

        public static void Instanciar(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string ConnectionString =>
            _configuration?.GetConnectionString("ConexionDB")
            ?? throw new InvalidOperationException("ConnectionString no configurada.");
    }
}
