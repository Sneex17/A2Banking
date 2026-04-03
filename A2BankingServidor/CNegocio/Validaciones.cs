using CEntidades;
using CEntidades.BuilderPattern;
using FluentValidation;

namespace CNegocio
{
    public class  ValidacionCuenta : AbstractValidator<Cuenta>
    {
        public ValidacionCuenta()
        {
            RuleFor(L => L.CodigoPin)
                .NotEmpty().WithMessage("Debe de ingresar un Código PIN");

            RuleFor(L => L.CodigoHuella)
                .NotEmpty().WithMessage("Debe de ingresar un Código de Huella");
        }
    }

    public class ValidacionUsuario : AbstractValidator<Usuario>
    {
        public ValidacionUsuario()
        {
            RuleFor(L => L.Nombre)
                .NotEmpty().WithMessage("Campo de nombre vacío, debe de ingresar un nombre");

            RuleFor(L => L.NombreUsuario)
                .NotEmpty().WithMessage("Campo de nombre de usuario vacío, debe de ingresar un nombre de usuario");

            RuleFor(L => L.Contrasena)
                .NotEmpty().WithErrorCode("Campo de contraseña vacío, debe de ingresar una contraseña");
        }
    }

    public class ValidacionTransferencia : AbstractValidator<Transferencia>
    {
        public ValidacionTransferencia()
        {
            RuleFor(L => L.Balance)
                .LessThanOrEqualTo(M => M.Monto).WithMessage("El monto a transferir debe ser menor o igual al balance actual");
        }
    }
}
