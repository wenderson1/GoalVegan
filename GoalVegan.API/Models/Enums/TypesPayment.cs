using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models.Enums
{
    public enum TypesPayment : ushort
    {
        Banking_Billet = 1,
        Debit_Card = 2,
        Credit_Card = 3,
        Pix=4
    }
}
