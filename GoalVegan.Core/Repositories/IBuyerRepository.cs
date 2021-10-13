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
        Task AddBuyerAsync();
        Task UpdateBuyerAsync();
    }
}
