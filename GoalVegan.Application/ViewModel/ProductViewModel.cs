using GoalVegan.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.ViewModel
{
    public class ProductViewModel
    {
        public ProductViewModel(string title, double price, string description, string linkImage, string category,Seller seller)
        {
            Title = title;
            Price = price;
            Description = description;
            LinkImage = linkImage;
            Category = category;
            Seller = seller;
        }

        public ProductViewModel(string title, double price, string description, string linkImage, string category, Seller seller, int idSeller)
        {
            Title = title;
            Price = price;
            Description = description;
            LinkImage = linkImage;
            Category = category;
            Seller = seller;
            IdSeller = idSeller;
        }

        public string Title { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public string? LinkImage { get; private set; }
        public string Category { get; private set; }
        public Seller Seller { get; private set; }
        public int IdSeller { get; private set; }
    }
}
