using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateSeller
{
   public class CreateSellerCommand : IRequest<int>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string RealName { get; set; }
        public string FantasyName { get; set; }
        public string Document { get; set; }
        public string StateRegister { get; set; }
        public string PixKey { get; set; }
    }
}
