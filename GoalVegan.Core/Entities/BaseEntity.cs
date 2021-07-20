using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models.Abstract
{
    public abstract class BaseEntity
    {
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }

        protected BaseEntity()
        {
           
            CreatedAt = DateTime.Now;
            Active = true;
        }

        public void DeactiveAccount()
        {
            Active = false;
        }
    }
}
