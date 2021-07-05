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
        public double Amount { get; private set; }
        public TypesPayment Payment { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<Product> Products { get; private set; }
        public int IdSeller { get; private set; }
        public int IdBuyer { get; private set; }
        public Buyer Customer { get; private set; }
        public Seller Vendor { get; private set; }

        public Order(int id, double amount, TypesPayment payment, OrderStatus status, int idSeller, int idBuyer, Buyer customer, Seller vendor) : base()
        {
            Id = id;
            Amount = amount;
            Payment = payment;
            Status = status;
            IdSeller = idSeller;
            IdBuyer = idBuyer;
            Customer = customer;
            Vendor = vendor;
        }
    }
}
