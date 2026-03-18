using CEntidades;
using Microsoft.Data.SqlClient;

namespace CDatos.Controllers
{
    public class RolController
    {
        private readonly static string _conexion = ConexionAppDB.ConnectionString;
        public static List<Rol> VerRoles()
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                var lista = new List<Rol>();
                acceso.Open();
                var comando = new SqlCommand("spVerRoles", acceso);
                var reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    lista.Add(new Rol() 
                    { 
                        RolId = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    });
                }
                reader.Close();
                acceso.Close();
                return lista;
            }
        }
    }
}
