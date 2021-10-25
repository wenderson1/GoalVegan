using GoalVegan.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetOrdersByBuyer
{
   public class GetOrdersByBuyerQuery:IRequest<List<Order>>
    {
        public GetOrdersByBuyerQuery(int idBuyer)
        {
            IdBuyer = idBuyer;
        }

        public int IdBuyer { get; private set; }
    }
}
