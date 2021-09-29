using GoalVegan.API.Models.Enums;
using GoalVegan.Core.Entities;
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
        private readonly GoalVeganDbContext _dbContext;

        public CreateOrderCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(30, request.Payment, request.IdSeller, request.IdBuyer);

            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();

            return order.Id;
        }
    }
}
