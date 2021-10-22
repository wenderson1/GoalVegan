using FluentValidation;
using GoalVegan.Application.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .WithMessage("Título é obrigatório");

            RuleFor(p => p.Title)
                .MinimumLength(10)
                .MaximumLength(150)
                .WithMessage("Título deve ter entre 10 a 150 caracteres");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("Preço é obrigatório");

            RuleFor(p => p.Price)
                .Must(ValidPrice)
                .WithMessage("Preço deve ser maior que 10");

            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull()
                .WithMessage("Descrição é obrigatório");

            RuleFor(p => p.Description)
                .MinimumLength(10)
                .MaximumLength(250)
                .WithMessage("Descrição deve ter entre 10 a 250 caracteres");

            RuleFor(p => p.Category)
                .NotEmpty()
                .NotNull()
                .WithMessage("Categoria é obrigatório");

            RuleFor(p => p.Title)
                .MinimumLength(10)
                .MaximumLength(60)
                .WithMessage("Categoria deve ter entre 10 a 60 caracteres");
        }

        public bool ValidPrice(double price)
        {
            price.ToString("0.00");

            if (price > 10)
            {
                return true;
            }

            return false;
        }
    }
}
