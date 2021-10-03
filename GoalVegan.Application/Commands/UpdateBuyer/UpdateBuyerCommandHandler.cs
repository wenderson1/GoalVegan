using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.UpdateBuyer
{
    public class UpdateBuyerCommandHandler : IRequestHandler<UpdateBuyerCommand, Unit>
    {
        private readonly GoalVeganDbContext _dbContext;

        public UpdateBuyerCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateBuyerCommand request, CancellationToken cancellationToken)
        {
            var buyer = await _dbContext.Buyers.SingleOrDefaultAsync(b => b.Id == request.Id);
            buyer.Update(request.Email, request.Password, request.PhoneNumber);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
