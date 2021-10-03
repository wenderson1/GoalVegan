using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.DeleteSeller
{
    public class DeleteSellerCommnadHandler : IRequestHandler<DeleteSellerCommand, Unit>
    {
        private readonly GoalVeganDbContext _dbContext;

        public DeleteSellerCommnadHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSellerCommand request, CancellationToken cancellationToken)
        {
            var seller = await _dbContext.Sellers.SingleOrDefaultAsync(s => s.Id == request.Id);
            seller.DeactiveAccount();
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
