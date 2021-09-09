using GoalVegan.API.Models;
using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Buyer;
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
    public class BuyerService : IBuyerService
    {
        private readonly GoalVeganDbContext _dbContext;
        public BuyerService(GoalVeganDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateBuyerInputModel inputModel)
        {
            var buyer = new Buyer(inputModel.Email, inputModel.Password, inputModel.PhoneNumber, inputModel.CPF);

            _dbContext.Buyers.Add(buyer);
            _dbContext.SaveChanges();
            return buyer.Id;
        }

        public void Delete(int id)
        {
            var buyer = _dbContext.Buyers.SingleOrDefault(p => p.Id == id);
            buyer.DeactiveAccount();
        }

        public BuyerDetailsViewModel GetById(int id)
        {
            var buyer = _dbContext.Buyers.SingleOrDefault(p => p.Id == id);
            var buyerViewModel = new BuyerDetailsViewModel(buyer.Email, buyer.Email, buyer.Document);
            return buyerViewModel;
        }

        public void Update(UpdateBuyerInputModel inputModel)
        {
            var buyer = _dbContext.Buyers.SingleOrDefault(p => p.Id == inputModel.Id);
            buyer.Update(inputModel.Email, inputModel.Password, inputModel.PhoneNumber);
        }


    }
}
