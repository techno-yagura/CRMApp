using CRMWindowsFormApp.Domain.Customers;
using System.Collections.Generic;
using System.Linq;

namespace CRMWindowsFormApp.Infrastructure.InMemory
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly Dictionary<string, Customer> data = new Dictionary<string, Customer>();

        public void Save(Customer customer)
        {
            data[customer.Id] = cloneCustomer(customer);
        }

        public Customer FindByCustomerName(string customername)
        {
            return data.Select(x => x.Value).FirstOrDefault(x => x.CustomerName == customername);
        }

        public IEnumerable<Customer> FindAll()
        {
            return data.Values;
        }

        private Customer cloneCustomer(Customer user)
        {
            return new Customer(user.Id, user.CustomerName);
        }
    }
}
