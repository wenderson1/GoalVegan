using GoalVegan.Application.InputModel.Seller;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.LoginSeller
{
    public class LoginSellerCommand : IRequest<SellerLoginModel>
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

       
    }
}
