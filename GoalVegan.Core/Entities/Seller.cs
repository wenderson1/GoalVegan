using System.Collections.Generic;

namespace GoalVegan.Core.Entities
{
    public class Seller : BaseEntity
    {
        protected Seller(int id, string email, string password, string phoneNumber, string realName, string fantasyName, string document, string stateRegister, string pixKey) : base()
        {
            Id = id;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            RealName = realName;
            FantasyName = fantasyName;
            Document = document;
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
        public string Document { get; private set; }
        public string StateRegister { get; private set; }
        public double Balance { get; private set; }
        public string PixKey { get; private set; }
        public int IdProduct { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdOrder { get; private set; }
        public List<Order> Orders { get; private set; }

    }
}
