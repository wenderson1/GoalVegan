using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel.Buyer
{
    public class BuyerLoginModel
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public BuyerLoginModel(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
