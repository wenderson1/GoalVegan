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

        public Task BilledOrderAsync(int id, string invoiceNumber, string KeyAcess)
        {
            throw new NotImplementedException();
        }

        public Task CancelOrderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateOrderAsync(double priceFreight, TypesPayment payment, int idSeller, int idBuyer)
        {
            throw new NotImplementedException();
        }

        public Task DeliveredOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == id);
        }

        public Task SentOrderAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
