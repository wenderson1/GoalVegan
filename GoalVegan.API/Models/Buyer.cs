using GoalVegan.API.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models
{
    public class Buyer : BaseEntity
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
#nullable enable
        public List<Card>? Cards { get; private set; }


        protected Buyer(int id, string email, string password, string phoneNumber) : base()
        {
            Id = id;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Cards = new List<Card>();
        }
    }
}
