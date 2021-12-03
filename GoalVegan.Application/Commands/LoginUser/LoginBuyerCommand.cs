using GoalVegan.Application.InputModel.Buyer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.LoginUser
{
    public class LoginBuyerCommand:IRequest<BuyerLoginModel>
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
