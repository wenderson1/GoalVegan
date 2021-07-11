using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models.SellerModels
{
    public class LoginModel
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
