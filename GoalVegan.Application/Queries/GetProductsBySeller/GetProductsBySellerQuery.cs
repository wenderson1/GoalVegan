using GoalVegan.Application.ViewModel;
using GoalVegan.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetProductsBySeller
{
    public class GetProductsBySellerQuery : IRequest<List<Product>>
    {
        public GetProductsBySellerQuery(int idSeller)
        {
            IdSeller = idSeller;
        }

        public int IdSeller { get; private set; }

    }
}
