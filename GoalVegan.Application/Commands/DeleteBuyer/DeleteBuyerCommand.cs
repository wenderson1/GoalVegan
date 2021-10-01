using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.DeleteBuyer
{
  public class DeleteBuyerCommand:IRequest<Unit>
    {
        public int Id { get; private set; }
    }
}
