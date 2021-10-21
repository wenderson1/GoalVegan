using FluentValidation;
using GoalVegan.Application.Commands.CreateSeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoalVegan.Application.Validators
{
    public class CreateSellerCommandValidator : AbstractValidator<CreateSellerCommand>
    {
        public CreateSellerCommandValidator()
        {
            RuleFor(p => p.Email)
                .EmailAddress()
                .WithMessage("Email não é válido!");

            RuleFor(p => p.Password)
                .Must(ValidPassword)
                .WithMessage("Senha deve conter 8 caracteres, um número, uma letra maiúscula, um caracter especial");

            RuleFor(p => p.FantasyName)
                .NotEmpty()
                .NotNull()
                .WithMessage("FantasyName é obrigatório"); 
            
            RuleFor(p => p.FantasyName)
                .MaximumLength(100)
                .MinimumLength(2)
                .WithMessage("FantasyName deve ter mais de 2 caracteres e menos de 100 caracteres");

            RuleFor(p => p.RealName)
                .NotEmpty()
                .NotNull()
                .WithMessage("RealName é obrigatório");

            RuleFor(p => p.RealName)
                .MaximumLength(100)
                .MinimumLength(2)
                .WithMessage("RealName deve ter mais de 2 caracteres e menos de 100 caracteres");

            RuleFor(p=>p.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .WithMessage("Número de Telefone é obrigatório");

            RuleFor(p => p.PhoneNumber)
                .MaximumLength(11)
                .MinimumLength(9)
                .WithMessage("Número de telefone deve ter de 9 a 11 caracteres");

            RuleFor(p => p.Document)
                .NotEmpty()
                .NotNull()
                .WithMessage("CNPJ é obrigatório");

            RuleFor(p => p.Document)
                .MaximumLength(13)
                .MinimumLength(12)
                .WithMessage("CNPJ deve ter 13 caracteres");

            RuleFor(p=>p.StateRegister)
                .NotEmpty()
                .NotNull()
                .WithMessage("Inscrição estadual é obrigatório");

            RuleFor(p => p.StateRegister)
                .MaximumLength(9)
                .MinimumLength(8)
                .WithMessage("Inscrição estadual deve ter 9 caracteres");

            RuleFor(p => p.PixKey)
                .NotEmpty()
                .NotNull()
                .WithMessage("Chave Pix é obrigatório");

            RuleFor(p => p.StateRegister)
               .MaximumLength(100)
               .MinimumLength(9)
               .WithMessage("Chave Pix deve conter entre 9 a 100 caracteres");

        }

        public bool ValidPassword (string password)
        {
            var regex = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");

            return regex.IsMatch(password);
        }
    }
}
