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

namespace GoalVegan.Application.Commands.UpdateSeller
{
    class UpdateSellerCommandHandler : IRequestHandler<UpdateSellerCommand, Unit>
    {
        private readonly ISellerRepository _sellerRepository;

        public UpdateSellerCommandHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public async Task<Unit> Handle(UpdateSellerCommand request, CancellationToken cancellationToken)
        {
            var seller = await _sellerRepository.GetSellerById(request.Id);

            seller.Update(request.Password, request.PixKey, request.PhoneNumber);
            await _sellerRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
