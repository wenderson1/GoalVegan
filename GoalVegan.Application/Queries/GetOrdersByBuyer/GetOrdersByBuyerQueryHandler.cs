using GoalVegan.Core.Entities;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetOrdersByBuyer
{
    public class GetOrdersByBuyerQueryHandler : IRequestHandler<GetOrdersByBuyerQuery, List<Order>>
    {
        private readonly GoalVeganDbContext _dbContext;

        public GetOrdersByBuyerQueryHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Order>> Handle(GetOrdersByBuyerQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Orders.Where(o => o.IdBuyer == request.IdBuyer).ToListAsync();
        }
    }
}
