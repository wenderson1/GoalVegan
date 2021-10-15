using GoalVegan.API.Models.Enums;
using GoalVegan.Core.Entities;
using GoalVegan.Core.Repositories;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(30, request.Payment, request.IdSeller, request.IdBuyer);

            await _orderRepository.AddOrderAsync(order);
            return order.Id;
        }
    }
}
