using GoalVegan.API.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models
{
    public class Seller : BaseEntity
    {
        protected Seller(int id, string email, string password, string phoneNumber, string realName, string fantasyName, string cnpj, string stateRegister, string pixKey) : base()
        {
            Id = id;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            RealName = realName;
            FantasyName = fantasyName;
            CNPJ = cnpj;
            StateRegister = stateRegister;
            Balance = 0;
            PixKey = pixKey;
            Products = new List<Product>();
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string RealName { get; private set; }
        public string FantasyName { get; private set; }
        public string CNPJ { get; private set; }
        public string StateRegister { get; private set; }
        public double Balance { get; private set; }
        public string PixKey { get; private set; }
        public List<Product> Products { get; private set; }

    }
}
