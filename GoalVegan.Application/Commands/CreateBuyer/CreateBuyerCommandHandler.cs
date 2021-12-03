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

namespace GoalVegan.Application.Commands.CreateBuyer
{
    public class CreateBuyerCommandHandler : IRequestHandler<CreateBuyerCommand, int>
    {
        private readonly GoalVeganDbContext _dbContext;
        private readonly IAuthService _authService;

        public CreateBuyerCommandHandler(GoalVeganDbContext dbContext, IAuthService authService)
        {
            _dbContext = dbContext;
            _authService = authService;
        }

        public async Task<int> Handle(CreateBuyerCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var buyer = new Buyer(request.Email, request.Password, request.PhoneNumber, request.Document, request.Role);

            await _dbContext.Buyers.AddAsync(buyer);

            await _dbContext.SaveChangesAsync();

            return buyer.Id;
        }
    }
}

