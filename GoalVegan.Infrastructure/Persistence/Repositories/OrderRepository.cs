using GoalVegan.API.Models.Enums;
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

        public async Task AddOrderAsync(Order order)
        {
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task BilledOrderAsync(Order order)
        {
            order.BilledOrder(order.InvoiceNumber, order.KeyAcess);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CancelOrderAsync(Order order)
        {
            order.CancelOrder();
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeliveredOrder(Order order)
        {
            order.DeliveredOrder();
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task SentOrderAsync(Order order)
        {
            order.SendOrder("21312312");
            await _dbContext.SaveChangesAsync();
        }
    }
}
