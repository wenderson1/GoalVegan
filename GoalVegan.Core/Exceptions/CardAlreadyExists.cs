using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Core
{
    class CardAlreadyExists:Exception
    {
        public CardAlreadyExists():base("Card Already exists in this account")
        {

        }
    }
}
