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

namespace GoalVegan.Application.Queries.GetSeller
{
    public class GetSellerByIdQueryHandler : IRequestHandler<GetSellerByIdQuery, SellerDetailsViewModel>
    {
        private readonly ISellerRepository _sellerRepository;

        public GetSellerByIdQueryHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public async Task<SellerDetailsViewModel> Handle(GetSellerByIdQuery request, CancellationToken cancellationToken)
        {
            var seller = await _sellerRepository.GetSellerById(request.Id);

            if (seller == null) return null;

            return new SellerDetailsViewModel(seller.Email, seller.PhoneNumber, seller.RealName, seller.FantasyName, seller.Document, seller.StateRegister, seller.Balance, seller.PixKey);
        }
    }
}
