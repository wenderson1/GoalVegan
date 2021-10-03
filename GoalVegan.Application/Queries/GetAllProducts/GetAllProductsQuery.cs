using GoalVegan.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetAllProducts
{
    public class GetAllProductsQuery:IRequest<List<ProductViewModel>>
    {
        public string Query { get; private set; }

        public GetAllProductsQuery(string query)
        {
            Query = query;
        }
    }
}
