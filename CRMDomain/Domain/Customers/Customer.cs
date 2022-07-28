namespace CRMDomain.Domain.Customers
{
    internal class Customer
    {
        internal Customer(string customerName)
        {
            Id = Guid.NewGuid().ToString();
            CustomerName = customerName;
        }

        internal string Id { get; }
        internal string CustomerName { get; }
    }
}
