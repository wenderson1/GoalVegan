using GoalVegan.Application.InputModel.Seller;
using GoalVegan.Core.Repositories;
using GoalVegan.Core.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.LoginSeller
{
    public class LoginSellerCommandHandler : IRequestHandler<LoginSellerCommand, SellerLoginModel>
    {
        private readonly IAuthService _authService;
        private readonly ISellerRepository _sellerRepository;

        public LoginSellerCommandHandler(IAuthService authService, ISellerRepository sellerRepository)
        {
            _authService = authService;
            _sellerRepository = sellerRepository;
        }

        public async Task<SellerLoginModel> Handle(LoginSellerCommand request, CancellationToken cancellationToken)
        {
            //utilizar o mesmo algoritmo para criar o hash dessa senha
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            //buscar no BD um user que tenha um email e senha em formato hash
            var seller = await _sellerRepository.GetSellerByEmailandPasswordAsync(request.Email, passwordHash);

            //se nao existir retornar erro no loign
            if(seller == null)
            {
                return null;
            }

            //Se existir gero token
            var token = _authService.GenerateJwtToken(seller.Email, "seller");
            return new SellerLoginModel(seller.Email, token);
        }
    }
}
