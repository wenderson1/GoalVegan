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
namespace GoalVegan.Application.Queries.GetUser
{
    public class GetByIdBuyerQueryHandler : IRequestHandler<GetByIdBuyerQuery, BuyerDetailsViewModel>
    {
        private readonly IBuyerRepository _buyerRepository;

        public GetByIdBuyerQueryHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public async Task<BuyerDetailsViewModel> Handle(GetByIdBuyerQuery request, CancellationToken cancellationToken)
        {
            
            var buyer = await _buyerRepository.GetById(request.Id);

            if (buyer is null) return null;

            return new BuyerDetailsViewModel(buyer.Email, buyer.PhoneNumber, buyer.Document);
        }
    }
}
