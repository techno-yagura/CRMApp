using CRMWinFormsApp.ApplicationLayer.Customers;
using System.Diagnostics;

namespace CRMWinFormsApp.ViewLayer
{
    public partial class FormMain : Form
    {
        private ICustomerGerListUseCase _customerGerListUseCase;

        public FormMain(ICustomerGerListUseCase customerGerListUseCase)
        {
            _customerGerListUseCase = customerGerListUseCase;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var response = _customerGerListUseCase.Handle(new CustomerGetListRequest());
            Debug.WriteLine("★★★");
            response.Summaries.ForEach(summary => Debug.WriteLine("顧客名：" + summary.CustomerName));
            Debug.WriteLine("★★★");
        }
    }
}
