using GoalVegan.API.Models;
using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel
{
   public class CreateOrderInputModel
    {
        public int Id { get; private set; }
        public double PriceFreight { get; private set; }
        public TypesPayment Payment { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdBuyer{ get; private set; }
        public int IdSeller { get; private set; }
    }
}
