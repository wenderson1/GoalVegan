using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.SentOrder
{
    public class SentOrderCommandHandler : IRequestHandler<SentOrderCommand,Unit>
    {
        private readonly GoalVeganDbContext _dbContext;

        public SentOrderCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(SentOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders.SingleOrDefaultAsync(o => o.Id == request.Id);
            order.SendOrder("Aleatorio");
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }

        
    }
}
