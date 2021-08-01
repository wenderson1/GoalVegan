using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel
{
   public class CreateCardInputModel
    {
        public string Number { get; private set; }
        public string CVV { get; private set; }
        public string CardName { get; private set; }
        public string NickName { get; private set; }
        public TypeCard Types { get; private set; }
    }
}
