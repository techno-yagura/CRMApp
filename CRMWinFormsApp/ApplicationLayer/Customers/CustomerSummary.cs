namespace CRMWinFormsApp.ApplicationLayer.Customers
{
    public class CustomerSummary
    {
        public CustomerSummary(string id, string customerName)
        {
            Id = id;
            CustomerName = customerName;
        }

        public string Id { get; }
        public string CustomerName { get; }
    }
}
