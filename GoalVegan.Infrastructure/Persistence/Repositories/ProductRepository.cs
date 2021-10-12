using GoalVegan.Core.Entities;
using GoalVegan.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Infrastructure.Persistence.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly GoalVeganDbContext _dbContext;

        public ProductRepository(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _dbContext.Products.SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
