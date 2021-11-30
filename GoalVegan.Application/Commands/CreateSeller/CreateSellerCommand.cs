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
        public CreateSellerCommand(string email, string password, string phoneNumber, string realName, string fantasyName, string document, string stateRegister, string pixKey, string role)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            RealName = realName;
            FantasyName = fantasyName;
            Document = document;
            StateRegister = stateRegister;
            PixKey = pixKey;
            Role = role;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string RealName { get; set; }
        public string FantasyName { get; set; }
        public string Document { get; set; }
        public string StateRegister { get; set; }
        public string PixKey { get; set; }
        public string Role { get; private set; }
    }
}
