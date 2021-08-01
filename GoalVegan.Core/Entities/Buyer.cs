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
        public string CPF { get; private set; }
#nullable enable
        public List<Card>? Cards { get; private set; }


        public Buyer(string email, string password, string phoneNumber, string cpf) : base()
        {

            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            CPF = cpf;
        }

        public void Update(string email, string password, string phoneNumber)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;

        }
    }
}
