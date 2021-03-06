using GoalVegan.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Core.Repositories
{
    public interface IBuyerRepository
    {
        Task<Buyer> GetById(int id);
        Task<List<Order>> GetOrdersByBuyer(int idBuyer);
        Task AddBuyerAsync(Buyer buyer);
        Task UpdateBuyerAsync(Buyer buyer);
        Task SaveChangesAsync();
        Task<Buyer> GetBuyerByEmailandPasswordAsync(string email, string passwordHash);
    }
}
