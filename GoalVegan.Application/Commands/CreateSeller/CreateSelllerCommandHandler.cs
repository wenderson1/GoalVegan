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

        public CreateSelllerCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> Handle(CreateSellerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
