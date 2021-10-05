using GoalVegan.Application.ViewModel;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetProduct
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductViewModel>
    {
        private readonly GoalVeganDbContext _dbContext;

        public GetProductByIdQueryHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products.SingleOrDefaultAsync(p => p.Id == request.Id);

            return new ProductViewModel(product.Title, product.Price, product.Description, product.LinkImage, product.Category);
        }
    }
}
