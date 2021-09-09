using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Seller;
using GoalVegan.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Services.Interfaces
{
    public interface ISellerService
    {
        SellerDetailsViewModel GetById(int id);
        int Create(CreateSellerInputModel inputModel);
        void Update(UpdateSellerInputModel inputModel);
        void Delete(int id);
    }
}
