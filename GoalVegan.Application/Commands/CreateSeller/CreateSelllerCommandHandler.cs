using GoalVegan.Core.Entities;
using GoalVegan.Core.Services;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateSeller
{
    public class CreateSelllerCommandHandler : IRequestHandler<CreateSellerCommand, int>
    {
        private readonly GoalVeganDbContext _dbContext;
        private readonly IAuthService _authService;

        public CreateSelllerCommandHandler(GoalVeganDbContext dbContext, IAuthService authService)
        {
            _dbContext = dbContext;
            _authService = authService;
        }

        public async Task<int> Handle(CreateSellerCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var seller = new Seller(request.Email, passwordHash,request.PhoneNumber,request.RealName, request.FantasyName, request.Document,request.StateRegister, request.PixKey, "seller");

            await _dbContext.Sellers.AddAsync(seller);

            await _dbContext.SaveChangesAsync();

            return seller.Id;
        }
    }
}
