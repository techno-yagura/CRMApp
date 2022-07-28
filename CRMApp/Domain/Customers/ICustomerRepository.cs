using System.Collections.Generic;

namespace CRMApp.Domain.Customers
{
    internal interface ICustomerRepository
    {
        void Save(Customer customer);
        Customer FindByUserName(string customerName);
        IEnumerable<Customer> FindAll();
    }
}
