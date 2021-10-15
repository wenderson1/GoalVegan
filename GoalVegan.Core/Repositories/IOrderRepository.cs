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
        Task BilledOrderAsync(Order order);
        Task CancelOrderAsync(Order order);
        Task SentOrderAsync(Order order);
        Task DeliveredOrder(Order order);
    }
}
