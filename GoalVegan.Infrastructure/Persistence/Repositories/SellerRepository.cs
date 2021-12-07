using GoalVegan.Core.Entities;
using GoalVegan.Core.Repositories;
using GoalVegan.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoalVegan.Core.Services;

namespace GoalVegan.Infrastructure.Persistence.Repositories
{
    public class SellerRepository : ISellerRepository
    {
        private readonly GoalVeganDbContext _dbContext;
        private readonly IAuthService _authService;

        public SellerRepository(GoalVeganDbContext dbContext, IAuthService authService)
        {
            _dbContext = dbContext;
            _authService = authService;
        }

        public async Task<List<Order>> GetOrdersBySeller(int idSeller)
        { 
            return await _dbContext.Orders.Where(o => o.IdSeller == idSeller).ToListAsync();
        }

        public async Task<List<Product>> GetProductsBySeller(int sellerId)
        {
            return await _dbContext.Products.Where(p => p.IdSeller == sellerId).ToListAsync();
        }

        public async Task<Seller> GetSellerByEmailandPasswordAsync(string email, string passwordHash)
        {
            return await _dbContext.Sellers.SingleOrDefaultAsync(s => s.Email == email && s.Password == passwordHash);
        }

        public async Task<Seller> GetSellerById(int id)
        {
            return await _dbContext.Sellers.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSellerAsync(Seller seller)
        {
            seller.Update(seller.PixKey, seller.PixKey, seller.PhoneNumber);
            await _dbContext.SaveChangesAsync();
        }
    }
}
