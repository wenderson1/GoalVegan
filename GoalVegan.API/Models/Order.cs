using GoalVegan.API.Models.Abstract;
using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Models
{
    public class Order : BaseEntity
    {
        public int Id { get; private set; }
        public double AmountProducts { get; private set; }
        public double PriceFreight { get; private set; }
        public double TotalAmount { get; private set; }
        public TypesPayment Payment { get; private set; }
        public OrderStatus Status { get; private set; }
#nullable enable
        public string? InvoiceNumber { get; private set; }
#nullable enable
        public string? KeyAcess { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdSeller { get; private set; }
        public int IdBuyer { get; private set; }
        public Buyer Customer { get; private set; }
        public Seller Vendor { get; private set; }

        public Order(int id, double priceFreight, TypesPayment payment, OrderStatus status, int idSeller, int idBuyer, Buyer customer, Seller vendor) : base()
        {
            Id = id;
            AmountProducts = Products.Sum(x=> x.Price);
            PriceFreight = priceFreight;
            TotalAmount = priceFreight + AmountProducts;
            Payment = payment;
            Status = status;
            IdSeller = idSeller;
            IdBuyer = idBuyer;
            Customer = customer;
            Vendor = vendor;
            Products = new List<Product>();
        }
    }
}
