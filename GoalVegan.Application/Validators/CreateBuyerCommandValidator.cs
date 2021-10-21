using FluentValidation;
using GoalVegan.Application.Commands.CreateBuyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Validators
{
    public class CreateBuyerCommandValidator:AbstractValidator<CreateBuyerCommand>
    {
    }
}
