using GoalVegan.API.Models;
using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.ViewModel
{
    class OrderDetailsBuyerViewModel
    {
        public double AmountProducts { get; private set; }
        public double PriceFreight { get; private set; }
        public double TotalAmount { get; private set; }
        public TypesPayment Payment { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdSeller { get; private set; }
    }
}
