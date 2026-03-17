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
    }
}
