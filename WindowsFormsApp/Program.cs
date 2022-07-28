using System;
using System.Windows.Forms;
using CRMWindowsFormApp.Application.Customers;
using CRMWindowsFormApp.Domain.Customers;
using CRMWindowsFormApp.Forms;
using CRMWindowsFormApp.Infrastructure.InMemory;
using Microsoft.Extensions.DependencyInjection;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCollection services = new ServiceCollection();

#if DEBUG
            ConfigureServicesDebug(services);
#else
            ConfigureServicesProduct(services);
#endif

            var serviceProvider = services.BuildServiceProvider();
            var form = serviceProvider.GetRequiredService<FormMain>();
            Application.Run(form);
        }

        private static void ConfigureServicesDebug(ServiceCollection services)
        {
            services.AddSingleton<FormMain>();
            services.AddScoped<ICustomerGerListUseCase, CustomerGetListInteractor>();
            services.AddScoped<ICustomerRepository, InMemoryCustomerRepository>();
        }

        private static void ConfigureServicesProduct(ServiceCollection services)
        {
            services.AddSingleton<FormMain>();
            services.AddScoped<ICustomerGerListUseCase, CustomerGetListInteractor>();
            services.AddScoped<ICustomerRepository, InMemoryCustomerRepository>();
        }
    }
}
