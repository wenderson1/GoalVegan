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
    public class OrderRepository : IOrderRepository
    {
        private readonly GoalVeganDbContext _dbContext;

        public OrderRepository(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == id);
        }
    }
}
