using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.UpdateSeller
{
    class UpdateSellerCommandHandler : IRequestHandler<UpdateSellerCommand, Unit>
    {
        private readonly GoalVeganDbContext _dbContext;
        public async Task<Unit> Handle(UpdateSellerCommand request, CancellationToken cancellationToken)
        {
            var seller = await _dbContext.Sellers.SingleOrDefaultAsync(s => s.Id == request.Id);
            seller.Update(request.Password, request.PixKey, request.PhoneNumber);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
