using Microsoft.Extensions.DependencyInjection;

namespace CRMApp
{
    public static class Startup
    {
//        public static void Run()
//        {
//#if DEBUG
//            setupDebug();
//#else
//            setupProduct();
//#endif
//            ServiceProvider.Build();
//        }

//        private static void setupProduct()
//        {
//            var services = ServiceProvider.ServiceCollection;
//            services.AddTransient<IUserRepository, UserRepository>();

//            services.AddTransient<IUserCreatePresenter, UserCreatePresenter>();

//            var busBuilder = new SyncUseCaseBusBuilder(services);
//            busBuilder.RegisterUseCase<UserCreateRequest, MockUserCreateInteractor>();
//            var bus = busBuilder.Build();
//            services.AddSingleton(bus);
//        }

//        private static void setupDebug()
//        {
//            var services = ServiceProvider.ServiceCollection;
//            services.AddTransient<IUserRepository, InMemoryUserRepository>();

//            services.AddTransient<IUserCreatePresenter, UserCreatePresenter>();

//            var busBuilder = new SyncUseCaseBusBuilder(services);
//            busBuilder.RegisterUseCase<UserCreateRequest, MockUserCreateInteractor>();
//            var bus = busBuilder.Build();
//            services.AddSingleton(bus);
//        }
    }
}
