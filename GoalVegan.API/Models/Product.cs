using GoalVegan.API.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models
{
    public class Product : BaseEntity
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public List<string> Photos { get; private set; }
        public int IdSeller { get; private set; }
        

        protected Product(int id, string title, double price, string description, string category, int idSeller):base()
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Category = category;
            IdSeller = idSeller;
            Photos = new List<string>();
        }
    }
}
