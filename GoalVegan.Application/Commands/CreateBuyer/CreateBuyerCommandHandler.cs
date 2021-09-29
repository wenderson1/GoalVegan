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

        public CreateBuyerCommandHandler(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> Handle(CreateBuyerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
