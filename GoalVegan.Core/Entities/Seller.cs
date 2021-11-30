using System.Collections.Generic;

namespace GoalVegan.Core.Entities
{
    public class Seller : BaseEntity
    {
        public Seller(string email, string password, string phoneNumber, string realName, string fantasyName, string document, string stateRegister, string pixKey, string role)
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

        public Seller(string email, string password, string phoneNumber, string realName, string fantasyName, string document, string cNPJ,string stateRegister, string pixKey, string role) : base()
        {
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
            Role = role;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public string RealName { get; set; }
        public string FantasyName { get; set; }
        public string Document { get; set; }
        public string StateRegister { get; set; }
        public double Balance { get; set; }
        public string PixKey { get; set; }
        public int IdProduct { get; set; }
        public List<Product>? Products { get; set; }
        public int IdOrder { get; set; }
        public List<Order> Orders { get; set; }


        public void Update(string password, string pixKey, string phoneNumber)
        {
            Password = password;
            PixKey = pixKey;
            PhoneNumber = phoneNumber;
        }
    }
}
