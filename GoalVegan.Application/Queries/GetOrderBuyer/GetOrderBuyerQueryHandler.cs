using GoalVegan.Application.Queries.GetOrder;
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

namespace GoalVegan.Application.Queries.GetOrderBuyer
{
    public class GetOrderBuyerQueryHandler : IRequestHandler<GetOrderBuyerQuery, OrderDetailsBuyerViewModel>
    {
        private readonly GoalVeganDbContext _dbContext;

        public GetOrderBuyerQueryHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderDetailsBuyerViewModel> Handle(GetOrderBuyerQuery request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders
                 .Include(b => b.Customer)//buyer
                 .Include(s => s.Vendor)//Seller
                 .SingleOrDefaultAsync(p => p.Id == request.Id);

            var orderDetailsBuyerViewModel = new OrderDetailsBuyerViewModel(order.AmountProducts, order.PriceFreight, order.PriceFreight, order.Payment,
                order.Status, order.InvoiceNumber, order.KeyAcess, order.Products, order.IdSeller, order.Vendor);

            return orderDetailsBuyerViewModel;
        }
    }
}
