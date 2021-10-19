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

namespace GoalVegan.Application.Commands.DeliveredOrder
{
    public class DeliveredOrderCommandHandler : IRequestHandler<DeliveredOrderCommand, Unit>
    {
        private readonly IOrderRepository _orderRepository;

        public DeliveredOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Unit> Handle(DeliveredOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetOrderById(request.Id);
            order.DeliveredOrder();

            return Unit.Value;
        }
    }
}
