
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.Core.Entities
{
    public class Buyer : BaseEntity
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Document { get; private set; }
        public int IdOrder { get; private set; }
        public List<Order> Orders { get; private set; }
       

        public Buyer(string email, string password, string phoneNumber, string document) : base()
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Document = document;
        }

        public void Update(string email, string password, string phoneNumber)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}
