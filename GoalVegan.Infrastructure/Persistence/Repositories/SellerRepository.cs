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
    public class SellerRepository : ISellerRepository
    {
        private readonly GoalVeganDbContext _dbContext;

        public SellerRepository(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Order>> GetOrdersBySeller(int idSeller)
        {
            return await _dbContext.Orders.Where(o => o.IdSeller == idSeller).ToListAsync();
        }

        public async Task<List<Product>> GetProductsBySeller(int sellerId)
        {
            return await _dbContext.Products.Where(p => p.IdSeller == sellerId).ToListAsync();
        }

        public async Task<Seller> GetSellerById(int id)
        {
            return await _dbContext.Sellers.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
