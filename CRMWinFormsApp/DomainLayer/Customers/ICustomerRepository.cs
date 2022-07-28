using System.Collections.Generic;

namespace CRMWinFormsApp.DomainLayer.Customers
{
    public interface ICustomerRepository
    {
        public void Save(Customer customer);
        public Customer FindByUserName(string customerName);
        public IEnumerable<Customer> FindAll();
    }
}
