using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel
{
    public class CreateBuyerInputModel
    {
            public string Email { get; private set; }
            public string Password { get; private set; }
            public string PhoneNumber { get; private set; }
            public string CPF { get; private set; }
         public string Role { get; private set; }
    }
}
