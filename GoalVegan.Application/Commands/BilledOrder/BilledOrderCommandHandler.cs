using GoalVegan.Core.Repositories;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateSeller
{
    public class BilledOrderCommandHandler : IRequestHandler<BilledOrderCommand, Unit>
    {
        private readonly GoalVeganDbContext _dbContext;

        public BilledOrderCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(BilledOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders.SingleOrDefaultAsync(o => o.Id == request.Id);
            order.BilledOrder(request.InvoiceNumber, request.KeyAcess);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
