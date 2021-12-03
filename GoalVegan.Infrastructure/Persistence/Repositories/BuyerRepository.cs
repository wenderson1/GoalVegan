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
    public class BuyerRepository:IBuyerRepository
    {
        private readonly GoalVeganDbContext _dbContext;

        public BuyerRepository(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddBuyerAsync(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public async Task<Buyer> GetBuyerByEmailandPasswordAsync(string email, string passwordHash)
        {
            return await _dbContext.
                Buyers.
                SingleOrDefaultAsync(u => u.Email == email && u.Password == passwordHash);
        }

        public async Task<Buyer> GetById(int id)
        {
            return await _dbContext.Buyers.SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Order>> GetOrdersByBuyer(int idBuyer)
        {
            return await _dbContext.Orders.Where(o => o.IdBuyer == idBuyer).ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBuyerAsync(Buyer buyer)
        {
            buyer.Update(buyer.Email, buyer.Password, buyer.PhoneNumber);
            await _dbContext.SaveChangesAsync();
        }
    }
}
