using CEntidades;
using CEntidades.BuilderPattern;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CDatos.Controllers
{
    public class CuentaController
    {
        private readonly static string _conexion = ConexionAppDB.ConnectionString;
        
        
        public static DataTable VerListaCuentas()
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                var tablaCuentas = new DataTable();

                var comando = new SqlCommand("spListaCuentas", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                var adapter = new SqlDataAdapter(comando);
                adapter.Fill(tablaCuentas);

                return tablaCuentas;
            }
        }
        
        public static void CrearCuenta(Cuenta cuenta)
        {  
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();

                int resultado;
                var comando = new SqlCommand("spCrearCuenta", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@BancoId", cuenta.Banco.BancoId);
                comando.Parameters.AddWithValue("@NumeroCuenta", cuenta.NumeroCuenta);
                comando.Parameters.AddWithValue("@TitularId", cuenta.Titular.TitularId);
                comando.Parameters.AddWithValue("@Balance", cuenta.Balance);
                comando.Parameters.AddWithValue("@FechaCreacion", cuenta.FechaCreacion);
                comando.Parameters.AddWithValue("@EstadoId", cuenta.Estado.cuentaEstado.EstadoID);
                comando.Parameters.AddWithValue("@CodigoPin", cuenta.CodigoPin);
                comando.Parameters.AddWithValue("@CodigoHuella", cuenta.CodigoHuella);

                resultado = comando.ExecuteNonQuery();
                acceso.Close();
            }
        }


        public static void DepositarBalance(Cuenta cuenta)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();

                int resultado;
                var comando = new SqlCommand("spDepositarBalanceCuenta", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("@NumeroCuenta", cuenta.NumeroCuenta);
                comando.Parameters.AddWithValue("@TitularId", cuenta.Titular.TitularId);
                comando.Parameters.AddWithValue("@Balance", cuenta.Balance);

                resultado = comando.ExecuteNonQuery();
                acceso.Close();
            }
        }

        public static void RetirarBalance(Cuenta cuenta)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();

                int resultado;
                var comando = new SqlCommand("spRetirarBalanceCuenta", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NumeroCuenta", cuenta.NumeroCuenta);
                comando.Parameters.AddWithValue("@TitularId", cuenta.Titular.TitularId);
                comando.Parameters.AddWithValue("@Balance", cuenta.Balance);

                resultado = comando.ExecuteNonQuery();
                acceso.Close();
            }
        }

        public static void CambiarEstado(Cuenta cuenta)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();

                int resultado;
                var comando = new SqlCommand("spCambiarEstadoCuenta", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NumeroCuenta", cuenta.NumeroCuenta);
                comando.Parameters.AddWithValue("@TitularId", cuenta.Titular.TitularId);
                comando.Parameters.AddWithValue("@EstadoId", cuenta.Estado.cuentaEstado.EstadoID);

                resultado = comando.ExecuteNonQuery();
                acceso.Close();
            }
        }

        public static int NumeroCuenta()
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                int resultado;
                acceso.Open();
                var comando = new SqlCommand("spNumeroCuenta", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                resultado = (int)comando.ExecuteScalar();
                return resultado;
            }
        }
    }
}
