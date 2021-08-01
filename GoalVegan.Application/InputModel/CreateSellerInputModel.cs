using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel
{
    class CreateSellerInputModel
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string RealName { get; private set; }
        public string FantasyName { get; private set; }
        public string CNPJ { get; private set; }
        public string StateRegister { get; private set; }
    
    }
}
