using System;

namespace CRMWinFormsApp.DomainLayer.Customers
{
    public class Customer
    {
        public Customer(string id, string customerName)
        {
            Id = id;
            CustomerName = customerName;
        }

        public Customer(string customerName)
        {
            Id = Guid.NewGuid().ToString();
            CustomerName = customerName;
        }

        public string Id { get; }
        public string CustomerName { get; }
    }
}
