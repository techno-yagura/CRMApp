using CRMWinFormsApp.DomainLayer.Customers;
using System.Linq;

namespace CRMWinFormsApp.ApplicationLayer.Customers
{
    public class CustomerGetListInteractor : ICustomerGerListUseCase
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerGetListInteractor(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public CustomerGetListResponse Handle(CustomerGetListRequest request)
        {
            var customers = customerRepository.FindAll();
            return new CustomerGetListResponse(
                customers.Select(x => new CustomerSummary(x.Id, x.CustomerName)).ToList()
            );
        }
    }
}
