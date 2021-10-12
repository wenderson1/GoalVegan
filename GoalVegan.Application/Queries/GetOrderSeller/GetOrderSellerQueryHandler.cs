using GoalVegan.Application.ViewModel;
using GoalVegan.Core.Repositories;
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
        private readonly IOrderRepository _orderRepository;

        public GetOrderSellerQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<OrderDetailsSellerViewModel> Handle(GetOrderSellerQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetOrderById(request.Id);

            if (order == null) return null;

            var orderDetailsSellerViewModel = new OrderDetailsSellerViewModel(order.AmountProducts, order.PriceFreight, order.TotalAmount, order.Payment,
                order.Status, order.InvoiceNumber, order.KeyAcess, order.Products, order.IdBuyer, order.Customer);

            return orderDetailsSellerViewModel;
        }
    }
}
