using GoalVegan.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Infrastructure.Persistence
{
    public class GoalVeganDbContext
    {
        public List<Buyer> Buyers { get; private set; }
        
    }
}
