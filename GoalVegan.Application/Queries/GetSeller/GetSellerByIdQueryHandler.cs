using GoalVegan.Application.ViewModel;
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
        private readonly GoalVeganDbContext _dbContext;

        public GetSellerByIdQueryHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SellerDetailsViewModel> Handle(GetSellerByIdQuery request, CancellationToken cancellationToken)
        {
            var seller = await _dbContext.Sellers.SingleOrDefaultAsync(b => b.Id == request.Id);

            return new SellerDetailsViewModel(seller.Email, seller.PhoneNumber, seller.RealName, seller.FantasyName, seller.Document, seller.StateRegister, seller.Balance, seller.PixKey);
        }
    }
}
