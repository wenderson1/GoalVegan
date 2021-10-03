using System;
using System.Collections.Generic;

namespace GoalVegan.Core.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public string? LinkImage { get; private set; }
        public string Category { get; private set; }
        public Seller Seller { get; private set; }
        public int IdSeller { get; private set; }

        public Product(string title, double price, string description, string category, int idSeller) : base()
        {
            Title = title;
            Price = price;
            Description = description;
            Category = category;
            IdSeller = idSeller;
        }

        public void Update(string title, double price, string description, string linkImage)
        {
            Title = title;
            Price = price;
            Description = description;
            LinkImage = linkImage;
        }
    }
}
