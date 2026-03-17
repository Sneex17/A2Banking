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
    }
}
