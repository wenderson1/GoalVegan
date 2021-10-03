using GoalVegan.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetUser
{
    public class GetByIdBuyerQuery : IRequest<BuyerDetailsViewModel>
    {
        public int Id { get; private set; }

        public GetByIdBuyerQuery(int id)
        {
            Id = id;
        }
    }
}
