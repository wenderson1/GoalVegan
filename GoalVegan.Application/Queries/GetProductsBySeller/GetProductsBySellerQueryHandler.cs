using GoalVegan.Application.ViewModel;
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

namespace GoalVegan.Application.Queries.GetProductsBySeller
{
    public class GetProductsBySellerQueryHandler : IRequestHandler<GetProductsBySellerQuery, List<Product>>
    {
        private readonly ISellerRepository _sellerRepository;

        public GetProductsBySellerQueryHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public async Task<List<Product>> Handle(GetProductsBySellerQuery request, CancellationToken cancellationToken)
        {
            var products = await _sellerRepository.GetProductsBySeller(request.IdSeller);

            return products;
        }



    }
}
