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

namespace GoalVegan.Application.Commands.DeleteBuyer
{
    public class DeleteBuyerCommandHandler : IRequestHandler<DeleteBuyerCommand, Unit>
    {
        private readonly IBuyerRepository _buyerRepository;

        public DeleteBuyerCommandHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public async Task<Unit> Handle(DeleteBuyerCommand request, CancellationToken cancellationToken)
        {
            var buyer = await _buyerRepository.GetById(request.Id);
            buyer.DeactiveAccount();
            await _buyerRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
