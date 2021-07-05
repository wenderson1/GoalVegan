using GoalVegan.API.Models.Abstract;
using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models
{
    public class Card : BaseEntity
    {
        protected Card(int id, string number, string cvv, string cardName, string nickName,TypeCard types ) : base()
        {
            Id = id;
            Number = number;
            CVV = cvv;
            CardName = cardName;
            NickName = nickName;
            Types = types;
        }

        public int Id { get; private set; }
        public string Number { get; private set; }
        public string CVV { get; private set; }
        public string CardName { get; private set; }
        public string NickName { get; private set; }
        public TypeCard Types { get; private set; }
    }

}



