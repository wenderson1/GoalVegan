using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models.ViewModels.OrderModels
{
    public class UpdateOrderModel
    {
        public OrderStatus Status { get; private set; }
        #nullable enable
        public string? InvoiceNumber { get; private set; }
        #nullable enable
        public string? KeyAcess { get; private set; }
    }
}
