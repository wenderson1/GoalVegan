using GoalVegan.Core.Repositories;
using GoalVegan.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.UpdateBuyer
{
    public class UpdateBuyerCommandHandler : IRequestHandler<UpdateBuyerCommand, Unit>
    {
        private readonly IBuyerRepository _buyerRepository;

        public UpdateBuyerCommandHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public async Task<Unit> Handle(UpdateBuyerCommand request, CancellationToken cancellationToken)
        {
            var buyer = await _buyerRepository.GetById(request.Id);
            await _buyerRepository.UpdateBuyerAsync(buyer);
            return Unit.Value;
        }
    }
}
