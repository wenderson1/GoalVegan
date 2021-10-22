using FluentValidation;
using GoalVegan.Application.Commands.CreateBuyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoalVegan.Application.Validators
{
    public class CreateBuyerCommandValidator : AbstractValidator<CreateBuyerCommand>
    {
        public CreateBuyerCommandValidator()
        {
            RuleFor(b => b.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email é obrigatório");

            RuleFor(b => b.Email)
                .EmailAddress()
                .WithMessage("Email Inválido");

            RuleFor(b => b.Password)
                .NotEmpty()
                .NotNull()
                .WithMessage("Senha é obrigatório");

            RuleFor(b=>b.Password)
                .Must(ValidPassword)
                .WithMessage("Senha deve conter 8 caracteres, um número, uma letra maiúscula, um caracter especial");

            RuleFor(b => b.PhoneNumber)
              .NotEmpty()
              .NotNull()
              .WithMessage("Número de Telefone é obrigatório");

            RuleFor(b => b.PhoneNumber)
                .MaximumLength(11)
                .MinimumLength(9)
                .WithMessage("Número de telefone deve ter de 9 a 11 caracteres");

            RuleFor(b => b.Document)
                .NotEmpty()
                .NotNull()
                .WithMessage("CPF é obrigatório");

            RuleFor(b => b.Document)
                .MaximumLength(12)
                .MinimumLength(11)
                .WithMessage("CPF deve ter 12 caracteres");
        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");

            return regex.IsMatch(password);
        }
    }
}
