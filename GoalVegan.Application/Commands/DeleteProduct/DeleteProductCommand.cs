using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.DeleteProduct
{
    public class DeleteProductCommand:IRequest<Unit>
    {
        public int Id { get; private set; }
    }
}
