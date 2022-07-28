using CRMWindowsFormApp.Application.Customers;
using System;
using System.Windows.Forms;
using System.Linq;

namespace CRMWindowsFormApp.Forms
{
    public partial class FormMain : Form
    {
        private ICustomerGerListUseCase _customerGerListUse;

        public FormMain(ICustomerGerListUseCase customerGerListUseCase)
        {
            InitializeComponent();
            _customerGerListUse = customerGerListUseCase;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var response = _customerGerListUse.Handle(new CustomerGetListRequest());
            Console.WriteLine(response);
        }
    }
}
