using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Buyer;
using GoalVegan.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Services.Interfaces
{
    public interface IBuyerService
    {
        BuyerDetailsViewModel GetById(int id);
        int Create(CreateBuyerInputModel inputModel);
        void Update(UpdateBuyerInputModel inputModel);
        void Delete(int id);
        int CreateOrder(CreateOrderInputModel inputModel);
    }

}