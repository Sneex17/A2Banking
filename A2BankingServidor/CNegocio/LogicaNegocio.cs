using CDatos;
using CDatos.Controllers;
using CEntidades;

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



    }
}
