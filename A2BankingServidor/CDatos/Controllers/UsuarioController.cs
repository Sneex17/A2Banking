using CEntidades;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Controllers
{
    public class UsuarioController
    {
        private readonly static string _conexion = ConexionAppDB.ConnectionString;
        public static int ValidarUsuario(Usuario usuario)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                int resultado;
                acceso.Open();
                var comando = new SqlCommand("spExisteUsuario", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);

                resultado = (int)comando.ExecuteScalar();
                return resultado;
            }
        }

        public static DataTable ListaUsuarios()
        {
            var tablaUsuarios = new DataTable();
            using (var acceso = new SqlConnection(_conexion))
            {  
                var comando = new SqlCommand("spVerUsuarios", acceso);
                comando.CommandType= CommandType.StoredProcedure;
                var adapter = new SqlDataAdapter(comando);
                adapter.Fill(tablaUsuarios);
            }
            return tablaUsuarios;
        }

        public static void IngresarUsuario(Usuario usuario)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();
                int resultado;
                var comando = new SqlCommand("spAgregarUsuario", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@RolId", usuario.RolId);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);

                resultado = comando.ExecuteNonQuery();
                acceso.Close();
            } 
        }

        public static void ActualizarUsuario(Usuario usuario)
        {
            using (var acceso = new SqlConnection(_conexion))
            {
                acceso.Open();
                int resultado;
                var comando = new SqlCommand("spActualizarUsuario", acceso);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);
                comando.Parameters.AddWithValue("@RolId", usuario.RolId);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);

                resultado = comando.ExecuteNonQuery();
                acceso.Close();
            }
        }
    }
}
