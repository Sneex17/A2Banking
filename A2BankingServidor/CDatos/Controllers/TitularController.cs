using CEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CDatos.Controllers
{
    public class TitularController
    {
        private readonly static string _conexion = ConexionAppDB.ConnectionString;

        public static void InsertarCliente(Titular titular)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();

                int resultado;
                var comando = new SqlCommand("spInsertarTitular", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@TitularId", titular.TitularId);
                comando.Parameters.AddWithValue("@Nombre", titular.Nombre);
                comando.Parameters.AddWithValue("@Edad", titular.Edad);
                comando.Parameters.AddWithValue("@Sexo", titular.Sexo);
                comando.Parameters.AddWithValue("@Ocupacion", titular.Ocupacion);
                resultado = comando.ExecuteNonQuery();

                acceso.Close();
            }
        }

        public static List<Titular> VerTitulares()
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();
                var listaTitulares = new List<Titular>();

                var comando = new SqlCommand("spVerTitulares", acceso);
                //comando.CommandType = CommandType.StoredProcedure;
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listaTitulares.Add(new Titular()
                    { 
                        TitularId = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Edad = reader.GetInt32(2),
                        Sexo = reader.GetString(3)[0],
                        Ocupacion = reader.GetString(4)
                    });
                }
                reader.Close();
                acceso.Close();
                return listaTitulares; 
            }
        }
    }
}
