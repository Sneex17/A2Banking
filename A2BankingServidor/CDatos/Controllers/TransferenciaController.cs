using CEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CDatos.Controllers
{
    public class TransferenciaController
    {
        private readonly static string _conexion = ConexionAppDB.ConnectionString;
        public static List<Transferencia> VerTransferencias()
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                var lista = new List<Transferencia>();
                acceso.Open();
                var comando = new SqlCommand("spVerTransferencia", acceso);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Transferencia()
                    {
                        TransferenciaId = reader.GetInt32(0),
                        CuentaOrigenId = reader.GetInt32(1),
                        CuentaDestinoId = reader.GetInt32(2),
                        Monto =  reader.GetDecimal(3),
                        Comision = reader.GetDecimal(4),
                        Fecha = reader.GetDateTime(5),
                        Concepto = reader.GetString(6)
                    });
                }
                reader.Close();
                acceso.Close();
                return lista;
            }
        }

        public static void ProcesarTransferencia(Transferencia transferencia)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();
                int resultado;
                var comando = new SqlCommand("spTransferencias", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Monto", transferencia.Monto);
                comando.Parameters.AddWithValue("@CuentaOrigen", transferencia.CuentaOrigenId);
                comando.Parameters.AddWithValue("@CuentaDestino", transferencia.CuentaDestinoId);
                comando.Parameters.AddWithValue("@Concepto", transferencia.Concepto);
                comando.Parameters.AddWithValue("@Fecha", transferencia.Fecha);

                resultado = comando.ExecuteNonQuery();
                acceso.Close();
            }
        }

        public static DataTable ReciboTransferencias()
        {
            var tabla = new DataTable();

            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();
                var comando = new SqlCommand("spReciboTransferencia", acceso);
                comando.CommandType= CommandType.StoredProcedure;
                var adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);

                acceso.Close();
                return tabla;
            }
        }
        public static DataTable ReciboDeposito()
        {
            var tabla = new DataTable();

            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();
                var comando = new SqlCommand("spReciboDeposito", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                var adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);

                acceso.Close();
                return tabla;
            }
        }

        public static DataTable ReciboRetiro()
        {
            var tabla = new DataTable();

            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();
                var comando = new SqlCommand("spReciboRetiro", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                var adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);

                acceso.Close();
                return tabla;
            }
        }
    }
}
