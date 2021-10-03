using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public UpdateProductCommand(string title, double price, string description, string linkImage)
        {
            Title = title;
            Price = price;
            Description = description;
            LinkImage = linkImage;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public string? LinkImage { get; private set; }
    }
}
