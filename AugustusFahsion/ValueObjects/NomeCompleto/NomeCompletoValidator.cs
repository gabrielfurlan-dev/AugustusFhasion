using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model.ValueObjects.NomeCompleto
{
    public class NomeCompletoValidator : AbstractValidator<NomeCompletoModel>
    {
        public NomeCompletoValidator()
        {
            RuleFor(nomeCompleto =>
                nomeCompleto.Sobrenome).NotNull()
                .WithMessage("Nome ou sobrenome não podem ser nulos");
        }
    }
}
