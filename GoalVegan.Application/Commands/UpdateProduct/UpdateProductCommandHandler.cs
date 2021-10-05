using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly GoalVeganDbContext _dbContext;

        public UpdateProductCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products.SingleOrDefaultAsync(p => p.Id == request.Id);
            product.Update(request.Description, request.Price, request.Description, request.LinkImage);

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
