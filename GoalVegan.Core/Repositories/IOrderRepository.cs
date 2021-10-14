using GoalVegan.API.Models.Enums;
using GoalVegan.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderById(int id);
        Task AddOrderAsync(Order order);
        Task BilledOrderAsync(int id, string invoiceNumber, string KeyAcess);
        Task CancelOrderAsync(int id);
        Task SentOrderAsync(int id);
        Task DeliveredOrder(int id);
    }
}
