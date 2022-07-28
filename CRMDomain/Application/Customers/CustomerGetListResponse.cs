using CRMDomain.Application.Core;

namespace CRMDomain.Application.Customers
{
    public class CustomerGetListResponse : IResponse
    {
        public CustomerGetListResponse(List<CustomerSummary> summaries) {
            Summaries = summaries;
        }

        public List<CustomerSummary> Summaries { get; }
    }
}
