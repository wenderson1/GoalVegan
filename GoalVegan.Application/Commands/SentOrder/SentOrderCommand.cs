using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.SentOrder
{
    public class SentOrderCommand : IRequest<Unit>
    {
        public int Id { get; private set; }
    }
}
