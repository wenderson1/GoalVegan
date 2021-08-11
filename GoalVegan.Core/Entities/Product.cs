using System.Collections.Generic;

namespace GoalVegan.Core.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public List<string> LinkImage { get; private set; }
        public string Category { get; private set; }
        public Seller Seller { get; private set; }
        public int IdSeller { get; private set; }

        public Product(int id, string title, double price, string description, string category, int idSeller) : base()
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Category = category;
            IdSeller = idSeller;
            LinkImage = new List<string>();
        }
    }
}
