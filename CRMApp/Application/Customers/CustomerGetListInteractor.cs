using CRMApp.Domain.Customers;
using System.Linq;

namespace CRMApp.Application.Customers
{
    internal class CustomerGetListInteractor : ICustomerGerListUseCase
    {
        private readonly ICustomerRepository customerRepository;

        internal CustomerGetListInteractor(ICustomerRepository customerRepository)
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
