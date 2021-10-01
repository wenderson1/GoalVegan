using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.DeliveredOrder
{
    public class DeliveredOrderCommandHandler : IRequestHandler<DeliveredOrderCommand, Unit>
    {
        private readonly GoalVeganDbContext _dbContext;

        public DeliveredOrderCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeliveredOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders.SingleOrDefaultAsync(o => o.Id == request.Id);
            order.DeliveredOrder();
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
