using System;

namespace CRMWindowsFormApp.Domain.Customers
{
    internal class Customer
    {
        internal Customer(string id, string customerName)
        {
            Id = id;
            CustomerName = customerName;
        }

        internal Customer(string customerName)
        {
            Id = Guid.NewGuid().ToString();
            CustomerName = customerName;
        }

        internal string Id { get; }
        internal string CustomerName { get; }
    }
}
