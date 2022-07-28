using CRMWindowsFormApp.Domain.Customers;
using System.Collections.Generic;
using System.Linq;

namespace CRMWindowsFormApp.Infrastructure.InMemory
{
    internal class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly Dictionary<string, Customer> data = new Dictionary<string, Customer>()
        {
            { "1", new Customer("顧客1") },
            { "2", new Customer("顧客2") },
            { "3", new Customer("顧客3") }
        };

        public void Save(Customer customer)
        {
            data[customer.Id] = cloneCustomer(customer);
        }

        public IEnumerable<Customer> FindAll()
        {
            return data.Values;
        }

        public Customer FindByUserName(string customerName)
        {
            return data.Select(x => x.Value).FirstOrDefault(x => x.CustomerName == customerName);
        }

        private Customer cloneCustomer(Customer user)
        {
            return new Customer(user.Id, user.CustomerName);
        }
    }
}
