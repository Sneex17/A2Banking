using CEntidades;
using FluentValidation;

namespace CNegocio
{
    public class Validaciones : AbstractValidator<Cuenta>
    {
        public Validaciones()
        {
            RuleFor(M => M.NumeroCuenta)
                .NotEmpty().NotNull().WithMessage("EL campo de numero de cuenta no puede esta vacío");

            RuleFor(M => M.CodigoPin)
                .NotEmpty().NotNull().WithMessage("EL campo de PIN de cuenta no puede esta vacío");

        }
    }
}
