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

namespace GoalVegan.Application.Commands.DeleteSeller
{
    public class DeleteSellerCommnadHandler : IRequestHandler<DeleteSellerCommand, Unit>
    {
        private readonly ISellerRepository _sellerRepository;

        public DeleteSellerCommnadHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public async Task<Unit> Handle(DeleteSellerCommand request, CancellationToken cancellationToken)
        {
            var seller = await _sellerRepository.GetSellerById(request.Id);
            seller.DeactiveAccount();
            await _sellerRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
