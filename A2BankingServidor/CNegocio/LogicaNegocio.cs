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
        //Gestión de usuarios
        public static int UsuarioExiste(Usuario usuario)
        {
            return UsuarioController.ValidarUsuario(usuario);
        }
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
        public static List<Rol> ListaRoles()
        {
            return RolController.VerRoles();
        }



        //Gestión de las cuentas
        public static void CrearCuentas(Cuenta cuenta)
        {
            CuentaController.CrearCuenta(cuenta);
        }
        public static List<Titular> ListaTitulares()
        {
            return TitularController.VerTitulares();
        }
        public static DataTable ListaCuentas()
        {
            return CuentaController.VerListaCuentas();
        }
        public static string GeneralNumeroCuenta()
        {
            var NuevoNumero = CuentaController.NumeroCuenta();
            return Convert.ToString(NuevoNumero);
        }

        //Transferencias
        public static List<Transferencia> ListaTransferencias()
        {
            return TransferenciaController.VerTransferencias();
        }

        public static void ProcesarTransferencia(Transferencia transferencia)
        {
            TransferenciaController.ProcesarTransferencia(transferencia);
        }

    }
}
