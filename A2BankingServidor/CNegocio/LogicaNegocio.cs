using CDatos;
using CDatos.Controllers;
using CEntidades;
using CEntidades.BuilderPattern;
using System.Data;
using System.Xml.Serialization;

namespace CNegocio
{
    public class LogicaNegocio
    {
        public static int UsuarioExiste(Usuario usuario)
        {
            return UsuarioController.ValidarUsuario(usuario);
        }

        public static List<Rol> ListaRoles()
        {
            return RolController.VerRoles();
        }

        public static void CrearCuentas(Cuenta cuenta)
        {
            CuentaController.CrearCuenta(cuenta);
        }

        public static List<Titular> ListaTitulares()
        {
            return TitularController.VerTitulares();
        }

        //Gestión de usuarios
        public static DataTable ListaUsuarios()
        {
            return UsuarioController.ListaUsuarios();
        }
        public static void AgregarUsuario(Usuario usuario)
        {
            UsuarioController.IngresarUsuario(usuario);
        }
        public static void ActualizarUsuario(Usuario usuario)
        {
            UsuarioController.ActualizarUsuario(usuario);
        }



    }
}
