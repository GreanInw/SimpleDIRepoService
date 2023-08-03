using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SimpleDI.Training.DbContexts;
using SimpleDI.Training.Repositories.Identities;
using SimpleDI.Training.Repositories.Sales;
using SimpleDI.Training.Services.Identities.Memberships;
using SimpleDI.Training.Services.Sales.SaleOrders;
using System.Security.Principal;

namespace SimpleDI.Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void ManualDI()
        {
            //Manul create instant
            IIdentityDbContext identityDbContext = new IdentityDbContext();
            IMembershipRepository membershipRepository = new MembershipRepository(identityDbContext);
            IRegisterService registerService = new RegisterService(membershipRepository);
            registerService.RegisterAsync("simple", "12345");
        }

        static void AutoDI()
        {
            var builder = new ContainerBuilder();

            //DbContext.
            builder.RegisterType<IdentityDbContext>().As<IIdentityDbContext>();
            builder.RegisterType<SalesDbContext>().As<ISalesDbContext>();

            //Repository
            builder.RegisterType<MembershipRepository>().As<IMembershipRepository>();
            builder.RegisterType<SaleOrderRepository>().As<ISaleOrderRepository>();

            //Service
            builder.RegisterType<RegisterService>().As<IRegisterService>();
            builder.RegisterType<SaleOrderService>().As<ISaleOrderService>();

            //Use IServiceCollection of Microsoft
            IServiceCollection services = new ServiceCollection();

            //Add services into IServiceProvider 
            builder.Populate(services);

            //Build all service.
            var container = builder.Build();

            //Simple use
            using (var scope = container.BeginLifetimeScope())
            {
                var registerService = scope.Resolve<IRegisterService>();
            }
        }
    }
}