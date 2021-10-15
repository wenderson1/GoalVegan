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

namespace GoalVegan.Application.Commands.CreateSeller
{
    public class BilledOrderCommandHandler : IRequestHandler<BilledOrderCommand, Unit>
    {
        private readonly IOrderRepository _orderRepository;

        public BilledOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        public async Task<Unit> Handle(BilledOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetOrderById(request.Id);
            await _orderRepository.BilledOrderAsync(order);

            return Unit.Value;
        }
    }
}
