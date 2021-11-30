using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel
{
   public class CreateSellerInputModel
    {
        public CreateSellerInputModel(string email, string password, string phoneNumber, string realName, string fantasyName, string document, string stateRegister, string pixKey, string role)
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

        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string RealName { get; private set; }
        public string FantasyName { get; private set; }
        public string Document { get; private set; }
        public string StateRegister { get; private set; }
        public string PixKey { get; private set; }
        public string Role { get; private set; }

    }
}
