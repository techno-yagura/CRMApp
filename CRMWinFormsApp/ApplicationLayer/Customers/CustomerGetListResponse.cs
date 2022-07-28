using CRMWinFormsApp.ApplicationLayer.Core;
using System.Collections.Generic;

namespace CRMWinFormsApp.ApplicationLayer.Customers
{
    public class CustomerGetListResponse : IResponse
    {
        public CustomerGetListResponse(List<CustomerSummary> summaries) {
            Summaries = summaries;
        }

        public List<CustomerSummary> Summaries { get; }
    }
}
