using GoalVegan.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Core.Repositories
{
    public interface ISellerRepository
    {
        Task<List<Order>> GetOrdersBySeller(int sellerId);
        Task<List<Product>> GetProductsBySeller(int sellerId);
        Task<Seller> GetSellerById(int id);
        Task AddSellerAsync(Seller seller);
        Task UpdateSellerAsync(Seller seller);
        Task SaveChangesAsync();
    }
}
