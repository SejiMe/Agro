using Agro.Data;
using Agro.Features.Authentication;
using Agro.Features.Farms;
using Agro.Features.Layout;
using Agro.Features.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;


namespace Agro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var services = new ServiceCollection();
            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();
            using var login = serviceProvider.GetRequiredService<AuthForm>();
            
            Application.Run(login);
        }
       
        private static void ConfigureServices(IServiceCollection services)
        {
            // ...
            services.AddDbContext<ApplicationDBContext>();
            services.AddScoped<IPersonalRepository, PersonalRepository>();
            services.AddSingleton<IAuthenticationRepository, AuthenticationRepository>();
            services.AddScoped<IFarmRepository, FarmRepository>();

            // Controllers 
            services.AddSingleton<RegisterUC>();
            services.AddSingleton<AuthUC>();
            services.AddSingleton<GeneralNavigation>();
            services.AddScoped<InsuranceProfileController>();
            services.AddScoped<ProfileController>();

            // Forms
            services.AddSingleton<AuthForm>();
            services.AddSingleton<MainForm>();            
            // ...
        }
    }
}