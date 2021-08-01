using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.InputModel
{
    class CreateProductInputModel
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public List<string> LinkImage { get; private set; }
        public string Category { get; private set; }
        public int IdSeller { get; private set; }
    }
}
