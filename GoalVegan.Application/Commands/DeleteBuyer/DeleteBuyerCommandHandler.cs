using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.DeleteBuyer
{
    public class DeleteBuyerCommandHandler : IRequestHandler<DeleteBuyerCommand, Unit>
    {
        private readonly GoalVeganDbContext _dbContext;

        public DeleteBuyerCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBuyerCommand request, CancellationToken cancellationToken)
        {
            var buyer = await _dbContext.Buyers.FirstOrDefaultAsync(b => b.Id == request.Id);
            buyer.DeactiveAccount();
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
