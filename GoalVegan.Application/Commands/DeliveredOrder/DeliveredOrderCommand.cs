using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.DeliveredOrder
{
    public class DeliveredOrderCommand:IRequest<Unit>
    {
        public DeliveredOrderCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
