using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.ViewModel
{
   public class BuyerDetailsViewModel
    {
        public BuyerDetailsViewModel(string email, string phoneNumber, string cPF)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            CPF = cPF;
        }

        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CPF { get; private set; }
    }
}
