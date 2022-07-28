using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace CRMWindowsFormApp
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
            services.AddScoped<ICustomerGerListUseCase, MyService>();
        }

        private static void ConfigureServicesProduct(ServiceCollection services)
        {
            services.AddSingleton<FormMain>();
            services.AddScoped<ICustomerGerListUseCase, MyService>();
        }
    }
}
