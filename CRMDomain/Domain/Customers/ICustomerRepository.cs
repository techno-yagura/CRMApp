namespace CRMDomain.Domain.Customers
{
    internal interface ICustomerRepository
    {
        void Save(Customer customer);
        Customer FindByUserName(string customerName);
        IEnumerable<Customer> FindAll();
    }
}
