using GoalVegan.Application.ViewModel;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetOrderSeller
{
    public class GetOrderSellerQueryHandler : IRequestHandler<GetOrderSellerQuery, OrderDetailsSellerViewModel>
    {
        private readonly GoalVeganDbContext _dbContext;
        public async Task<OrderDetailsSellerViewModel> Handle(GetOrderSellerQuery request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders
                .Include(b => b.Customer)
                .Include(s => s.Vendor)
                .SingleOrDefaultAsync(o => o.Id == request.Id);

            var orderDetailsSellerViewModel = new OrderDetailsSellerViewModel(order.AmountProducts, order.PriceFreight,order.TotalAmount, order.Payment,
                order.Status, order.InvoiceNumber, order.KeyAcess, order.Products, order.IdBuyer, order.Customer);

            return orderDetailsSellerViewModel;
        }
    }
}
