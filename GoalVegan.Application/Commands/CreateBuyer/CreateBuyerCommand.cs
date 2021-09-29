using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateBuyer
{
    public class CreateBuyerCommand : IRequest<int>
    {

        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Document { get; private set; }
    }
}
