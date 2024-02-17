using Car_rental_system;
using City_car_rent.Service.Mappers;
using City_rent_car.Data.Repositories;
using City_rent_car.Data.IRepositories;
using City_car_rent.Service.Services.Users;
using City_car_rent.Service.Interfaces.Users;
using Microsoft.Extensions.DependencyInjection;

namespace City_car_rent
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            #region register services
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(MapperProfile));
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IUserService, UserService>();
            #endregion

            Application.Run(new InitialForm());
        }
    }
}