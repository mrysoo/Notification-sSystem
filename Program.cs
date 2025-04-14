using DataModel.DataBase;
using EntityGateWay;
using EntityGateWay.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NotificationsSystem.GUI.Forms;
using NotifiCommHub.Services;

namespace NotificationsSystem
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var authorizationF = ServiceProvider.GetRequiredService<AuthorizationF>();

            Application.Run(authorizationF);
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<BasicConfiguration>(sp =>
                    {
                        var configuration = sp.GetRequiredService<IConfiguration>();
                        return new BasicConfiguration(configuration);
                    });

                    var configuration = services.BuildServiceProvider().GetRequiredService<BasicConfiguration>();
                    services.AddDbContext<NotificationsDBContext>(options => options.UseSqlServer(configuration?.ConnectionString), ServiceLifetime.Scoped);

                    services.AddSingleton<FormNavigator>();
                    services.AddTransient<MainF>();
                    services.AddTransient<RegistrationF>();
                    services.AddTransient<AuthorizationF>();

                    services.AddScoped<IRepository<UserDTO, Guid>, UserRepository>();
                    services.AddScoped<IRepository<NotificationDTO, long>, NotificationRepository>();

                    services.AddScoped<IUserService, UserService>();
                    services.AddScoped<INotificationService, NotificationService>();

                    services.AddSingleton<UserStorage>();
                });
        }
    }
}