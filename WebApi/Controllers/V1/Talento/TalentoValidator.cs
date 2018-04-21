using System;
using FluentValidation;
using WebApi.Model;

namespace WebApi.Controllers.V1.Talento
{
    public class TalentoValidator : AbstractValidator<TalentoModel>
    {
        public TalentoValidator()
        {
            RuleFor(reg => reg.Nome).NotEmpty()
                                    .WithMessage("O campo 'nome' é de preenchimento obrigatorio");
            RuleFor(reg => reg.Email).NotEmpty()
                                     .WithMessage("O campo 'e-mail' é de preenchimento obrigatorio");
            RuleFor(reg => reg.Cidade).NotEmpty()
                                      .WithMessage("O campo 'Cidade' é de preenchimento obrigatorio");
            RuleFor(reg => reg.Estado).NotEmpty()
                                      .WithMessage("O campo ''Estado é de preenchimento obrigatorio");
            RuleFor(reg => reg.Pretensao).NotEmpty()
                                         .WithMessage("O campo 'Pretencao' é de preenchimento obrigatorio");
            RuleFor(reg => reg.Skype).NotEmpty()
                                     .WithMessage("O campo 'skype' é de preenchimento obrigatorio");
            RuleFor(reg => reg.Telefone).NotEmpty()
                                        .WithMessage("O campo 'Telefone' é de preenchimento obrigatorio");
        }
    }
}
