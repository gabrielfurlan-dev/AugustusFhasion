using FluentValidation;

namespace AugustusFahsion.Model.ValueObjects.Cpf
{
    class CpfValidator : AbstractValidator<CpfModel>
    {
        public CpfValidator()
        {
            RuleFor(x => x.ToString()).NotNull().NotEmpty().WithMessage("Cpf não pode ser nulo/vazio ");
            RuleFor(x => x.ToString()).Length(11).WithMessage("Cpf deve conter 11 números");
        }

    }
}
