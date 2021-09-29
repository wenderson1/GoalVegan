using GoalVegan.API.Models.Enums;
using GoalVegan.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<int>
    {
        public double AmountProducts { get; private set; }
        public double PriceFreight { get; private set; }
        public double TotalAmount { get; private set; }
        public TypesPayment Payment { get; private set; }
        public string? InvoiceNumber { get; private set; }
        public string? KeyAcess { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdSeller { get; private set; }
        public int IdBuyer { get; private set; }
        public Buyer Customer { get; private set; }
        public Seller Vendor { get; private set; }
    }
}
