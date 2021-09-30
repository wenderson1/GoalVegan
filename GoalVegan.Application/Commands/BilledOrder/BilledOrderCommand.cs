using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands
{
    public class BilledOrderCommand : IRequest<Unit>
    {
        public int Id { get; private set; }
        public string? InvoiceNumber { get; private set; }
        public string? KeyAcess { get; private set; }


    }
}
