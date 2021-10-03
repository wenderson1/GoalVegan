using GoalVegan.API.Models;
using GoalVegan.API.Models.Enums;
using GoalVegan.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.ViewModel
{
    public class OrderDetailsSellerViewModel
    {
        public OrderDetailsSellerViewModel(double amountProducts, double priceFreight, double totalAmount, TypesPayment payment, OrderStatus status, string invoiceNumber, string keyAcess, List<Product> products, int idBuyer, Buyer customer)
        {
            AmountProducts = amountProducts;
            PriceFreight = priceFreight;
            TotalAmount = totalAmount;
            Payment = payment;
            Status = status;
            InvoiceNumber = invoiceNumber;
            KeyAcess = keyAcess;
            Products = products;
            IdBuyer = idBuyer;
            Customer = customer;
        }

        public double AmountProducts { get; private set; }
        public double PriceFreight { get; private set; }
        public double TotalAmount { get; private set; }
        public TypesPayment Payment { get; private set; }
        public OrderStatus Status { get; private set; }
        public string? InvoiceNumber { get; private set; }
        public string? KeyAcess { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdBuyer { get; private set; }
        public Buyer Customer { get; private set; }
    }
}
