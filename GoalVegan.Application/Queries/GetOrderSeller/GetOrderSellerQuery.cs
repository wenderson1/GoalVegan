using GoalVegan.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetOrderSeller
{
    public class GetOrderSellerQuery : IRequest<OrderDetailsSellerViewModel>
    {
        public int Id { get; private set; }

        public GetOrderSellerQuery(int id)
        {
            Id = id;
        }
    }
}
