using Car_rental_system;
using City_car_rent.Service.Interfaces.Customers;
using City_car_rent.Service.Mappers;
using City_car_rent.Service.Services.Users;
using City_rent_car.Data.Data;
using City_rent_car.Data.IRepositories;
using City_rent_car.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace City_car_rent
{
    public static class Program
    {
        private static IServiceProvider _serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            #region register services
            var services = new ServiceCollection();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            });

            services.AddAutoMapper(typeof(MapperProfile));
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddScoped<ICustomerRepository,CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            #endregion

            // Build the service provider
            _serviceProvider = services.BuildServiceProvider();

            Application.Run(new InitialForm());
        }

        public static T GetService<T>()
        {
            return  _serviceProvider.GetRequiredService<T>();
        }
    }
}