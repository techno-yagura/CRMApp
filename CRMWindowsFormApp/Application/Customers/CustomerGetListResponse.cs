using CRMWindowsFormApp.Application.Core;
using System.Collections.Generic;

namespace CRMWindowsFormApp.Application.Customers
{
    public class CustomerGetListResponse : IResponse
    {
        public CustomerGetListResponse(List<CustomerSummary> summaries) {
            Summaries = summaries;
        }

        public List<CustomerSummary> Summaries { get; }
    }
}
