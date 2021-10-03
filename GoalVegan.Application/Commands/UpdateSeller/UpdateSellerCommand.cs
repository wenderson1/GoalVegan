using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.UpdateSeller
{
    public class UpdateSellerCommand:IRequest<Unit>
    {
        public UpdateSellerCommand(string password, string phoneNumber, string pixKey)
        {
            Password = password;
            PhoneNumber = phoneNumber;
            PixKey = pixKey;
        }

        public int Id { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public string PixKey { get; private set; }
    }
}
