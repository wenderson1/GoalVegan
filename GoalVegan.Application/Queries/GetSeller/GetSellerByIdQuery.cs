using GoalVegan.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetSeller
{
    public class GetSellerByIdQuery:IRequest<SellerDetailsViewModel>
    {
        public int Id{ get; private set; }

        public GetSellerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
