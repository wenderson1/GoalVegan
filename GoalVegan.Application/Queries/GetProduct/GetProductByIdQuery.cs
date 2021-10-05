using GoalVegan.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetProduct
{
    public class GetProductByIdQuery:IRequest<ProductViewModel>
    {
        public int Id { get; private set; }
    }
}
