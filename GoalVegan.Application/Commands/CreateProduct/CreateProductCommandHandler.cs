using GoalVegan.Core.Entities;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly GoalVeganDbContext _dbContext;

        public CreateProductCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Title, request.Price, request.Description,request.Category, request.IdSeller);

            await _dbContext.AddAsync(product);

            return product.Id;
        }
    }
}
