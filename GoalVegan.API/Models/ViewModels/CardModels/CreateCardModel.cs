using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models.ViewModels.CardModels
{
    public class CreateCardModel
    {
        public string Number { get; private set; }
        public string CardName { get; private set; }
        public string NickName { get; private set; }
        public TypeCard Types { get; private set; }
    }
}
