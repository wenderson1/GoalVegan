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

namespace GoalVegan.Application.Queries.GetOrdersBySeller
{
    public class GetOrderBySellerQueryHandler : IRequestHandler<GetOrderBySellerQuery, List<Order>>
    {
        private readonly ISellerRepository _sellerRepository;

        public GetOrderBySellerQueryHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public async Task<List<Order>> Handle(GetOrderBySellerQuery request, CancellationToken cancellationToken)
        {
            
            return await _sellerRepository.GetOrdersBySeller(request.IdSeller);

        }
    }
}
