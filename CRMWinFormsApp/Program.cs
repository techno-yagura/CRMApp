using CRMWinFormsApp.ApplicationLayer.Customers;
using CRMWinFormsApp.DomainLayer.Customers;
using CRMWinFormsApp.InfrastructureLayer.InMemory;
using CRMWinFormsApp.ViewLayer;
using Microsoft.Extensions.DependencyInjection;

namespace CRMWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

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