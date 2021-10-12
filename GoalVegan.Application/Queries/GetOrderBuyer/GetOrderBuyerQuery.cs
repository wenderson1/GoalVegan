using GoalVegan.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetOrder
{
    public class GetOrderBuyerQuery:IRequest<List<OrderDetailsBuyerViewModel>>
    {
        public int Id { get; private set; }

        public GetOrderBuyerQuery(int id)
        {
            Id = id;
        }
    }
}
