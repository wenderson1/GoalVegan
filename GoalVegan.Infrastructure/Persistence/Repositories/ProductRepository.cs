using GoalVegan.Core.Entities;
using GoalVegan.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Infrastructure.Persistence.Repositories
{
    public class ProductRepository:IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
    }
}
