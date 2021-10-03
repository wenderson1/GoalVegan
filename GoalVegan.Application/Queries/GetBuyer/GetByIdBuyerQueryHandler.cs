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
namespace GoalVegan.Application.Queries.GetUser
{
    public class GetByIdBuyerQueryHandler : IRequestHandler<GetByIdBuyerQuery, BuyerDetailsViewModel>
    {
        private GoalVeganDbContext _dbContext;

        public GetByIdBuyerQueryHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BuyerDetailsViewModel> Handle(GetByIdBuyerQuery request, CancellationToken cancellationToken)
        {
            
            var buyer =  await _dbContext.Buyers.SingleOrDefaultAsync(b => b.Id == request.Id);

            return new BuyerDetailsViewModel(buyer.Email, buyer.PhoneNumber, buyer.Document);
        }
    }
}
