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

namespace GoalVegan.Application.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductViewModel>>
    {
        private readonly GoalVeganDbContext _dbContext;

        public GetAllProductsQueryHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProductViewModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _dbContext.Products.ToListAsync();

            var productsViewModel = products
                .Select(p => new ProductViewModel(p.Title, p.Price, p.Description, p.LinkImage, p.Category))
                .ToList();

            return productsViewModel;
        }
    }
}
