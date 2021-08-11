using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel.Seller
{
    public class UpdateInputSellerModel
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string RealName { get; private set; }
        public string FantasyName { get; private set; }
        public string PixKey { get; private set; }
    }
}
