using GoalVegan.Core.Entities;
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

namespace GoalVegan.Application.Queries.GetOrdersByBuyer
{
    public class GetOrdersByBuyerQueryHandler : IRequestHandler<GetOrdersByBuyerQuery, List<Order>>
    {
        private readonly IBuyerRepository _buyerRepository;

        public GetOrdersByBuyerQueryHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public async Task<List<Order>> Handle(GetOrdersByBuyerQuery request, CancellationToken cancellationToken)
        {
            return await _buyerRepository.GetOrdersByBuyer(request.IdBuyer);
        }
    }
}
