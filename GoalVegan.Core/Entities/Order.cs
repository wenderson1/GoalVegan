
using GoalVegan.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoalVegan.Core.Entities
{
    public class Order : BaseEntity
    {
        public int Id { get; private set; }
        public double AmountProducts { get; private set; }
        public double PriceFreight { get; private set; }
        public double TotalAmount { get; private set; }
        public TypesPayment Payment { get; private set; }
        public OrderStatus Status { get; private set; }
        public string? InvoiceNumber { get; private set; }
        public string? KeyAcess { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdSeller { get; private set; }
        public int IdBuyer { get; private set; }
        public Buyer Customer { get; private set; }
        public Seller Vendor { get; private set; }

              public Order(double priceFreight, TypesPayment payment, int idSeller, int idBuyer) : base()
        {
            
            AmountProducts = Products.Sum(x => x.Price);
            PriceFreight = priceFreight;
            TotalAmount = priceFreight + AmountProducts;
            Payment = payment;
            Status = OrderStatus.New;
            IdSeller = idSeller;
            IdBuyer = idBuyer;
            Products = new List<Product>();
        }

        public void BilledOrder(string invoiceNumber, string keyAcess)
        {
            InvoiceNumber = invoiceNumber;
            KeyAcess = keyAcess;
            Status = OrderStatus.Billed;
        }

        public void SendOrder(string trackingCode)
        {
            //a idéia seria mandar um email
           Console.WriteLine("The order id " + Id  + "receive a tracking code: " + trackingCode);
            Status = OrderStatus.Sent;
        }

        public void CancelOrder()
        {
            Status = OrderStatus.Canceled;
        }

        public void DeliveredOrder()
        {
            Status = OrderStatus.Delivered;
        }
    }
}
