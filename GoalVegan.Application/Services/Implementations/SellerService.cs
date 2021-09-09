using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Seller;
using GoalVegan.Application.Services.Interfaces;
using GoalVegan.Application.ViewModel;
using GoalVegan.Core.Entities;
using GoalVegan.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Services.Implementations
{
    public class SellerService : ISellerService
    {
        private readonly GoalVeganDbContext _dbContext;

        public SellerService(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateSellerInputModel inputModel)
        {
            var seller = new Seller(
               inputModel.Email,
               inputModel.Password,
               inputModel.PhoneNumber,
               inputModel.RealName,
               inputModel.FantasyName,
               inputModel.Document,
               inputModel.StateRegister,
               inputModel.PixKey
                );

            _dbContext.Add(seller);
            _dbContext.SaveChanges();
            return seller.Id;
        }

        public void Delete(int id)
        {
            var seller = _dbContext.Sellers.SingleOrDefault(s => s.Id == id);
            seller.DeactiveAccount();
            _dbContext.SaveChanges();

        }

        public SellerDetailsViewModel GetById(int id)
        {
            var seller = _dbContext.Sellers.SingleOrDefault(s => s.Id == id);
            var sellerViewModel = new SellerDetailsViewModel(
                seller.Email,
                seller.PhoneNumber,
                seller.RealName,
                seller.FantasyName,
                seller.Document,
                seller.StateRegister,
                seller.Balance,
                seller.PixKey
              );
            return sellerViewModel;
        }

        public void Update(UpdateSellerInputModel inputModel)
        {
            var seller = _dbContext.Sellers.SingleOrDefault(s => s.Id == inputModel.Id);
            seller.Update(inputModel.Password, inputModel.PixKey, inputModel.PhoneNumber);

        }
    }
}
