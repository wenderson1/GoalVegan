using GoalVegan.Core.Entities;
using GoalVegan.Core.Repositories;
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

        public Task<List<Order>> GetOrdersBySeller()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsBySeller()
        {
            throw new NotImplementedException();
        }

        public Task<Seller> GetSellerById()
        {
            throw new NotImplementedException();
        }
    }
}
