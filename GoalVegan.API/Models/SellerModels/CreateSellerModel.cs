using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models.SellerModels
{
    public class CreateSellerModel
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string RealName { get; private set; }
        public string FantasyName { get; private set; }
        public string CNPJ { get; private set; }
        public string StateRegister { get; private set; }
        public string PixKey { get; private set; }
    }
}
