using GoalVegan.Application.InputModel.Buyer;
using GoalVegan.Core.Repositories;
using GoalVegan.Core.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.LoginUser
{
    public class LoginBuyerCommandHandler : IRequestHandler<LoginBuyerCommand, BuyerLoginModel>
    {
        private readonly IAuthService _authService;
        private readonly IBuyerRepository _buyerRepository;

        public LoginBuyerCommandHandler(IAuthService authService, IBuyerRepository buyerRepository)
        {
            _authService = authService;
            _buyerRepository = buyerRepository;
        }

        public async Task<BuyerLoginModel> Handle(LoginBuyerCommand request, CancellationToken cancellationToken)
        {
            //utilizar o mesmo algoritmo para criar o hash dessa senha
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            //buscar no bd um user que tenha meu email e minha senha em formato hash
            var buyer = await _buyerRepository.GetBuyerByEmailandPasswordAsync(request.Email, passwordHash);

            //se nao existir, erro no login
            if (buyer == null)
            {
                return null;
            }

            //Se existir gero token
            var token = _authService.GenerateJwtToken(buyer.Email, "buyer");
            return new BuyerLoginModel(buyer.Email, token);
        }
    }
}
