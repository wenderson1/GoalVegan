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

namespace GoalVegan.Application.Queries.GetOrdersBySeller
{
    public class GetOrderBySellerQueryHandler : IRequestHandler<GetOrderBySellerQuery, List<Order>>
    {
        private GoalVeganDbContext _dbContext;

        public GetOrderBySellerQueryHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Order>> Handle(GetOrderBySellerQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Orders.Where(o => o.IdSeller == request.IdSeller).ToListAsync();
        }
    }
}
