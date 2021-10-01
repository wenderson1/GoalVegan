using GoalVegan.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateProduct
{
    public class CreateProductCommand:IRequest<int>
    {
        public string Title { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public int IdSeller { get; private set; }
    }
}
