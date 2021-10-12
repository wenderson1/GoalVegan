using GoalVegan.Application.Queries.GetOrder;
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

namespace GoalVegan.Application.Queries.GetOrderBuyer
{
    public class GetOrderBuyerQueryHandler : IRequestHandler<GetOrderBuyerQuery, OrderDetailsBuyerViewModel>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderBuyerQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<OrderDetailsBuyerViewModel> Handle(GetOrderBuyerQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetOrderById(request.Id);

            if (order is null) return null;

            return new OrderDetailsBuyerViewModel(
                order.AmountProducts,
                order.PriceFreight,
                order.TotalAmount,
                order.Payment,
                order.Status,
                order.InvoiceNumber,
                order.KeyAcess,
                order.Products,
                order.IdSeller,
                order.Vendor
                );
        }
    }
}
