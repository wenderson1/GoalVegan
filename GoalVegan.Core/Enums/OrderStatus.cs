using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models.Enums
{
    public enum OrderStatus
    {
        New,
        Billed,
        Sent,
        Delivered, 
        Canceled,
        Returned
    }
}
