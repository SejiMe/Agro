using Agro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Agro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static ServiceProvider ServiceProvider { get; private set; }

        static void Config()
        {
            // Fluent Style
            ServiceProvider = new ServiceCollection()
                .AddTransient<Form1>()
                .AddDbContext<ApplicationDBContext>(options =>
                {
                    options.UseSqlServer("Data Source=JIVAN;Initial Catalog=AgroDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
                })
                .BuildServiceProvider();
        }

        static void Shutdown()
        {
            ServiceProvider?.Dispose();
        }

        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //ServiceCollection services = new ServiceCollection();

            

            Config();
           
            var form1 = ServiceProvider.GetRequiredService<Form1>();
            
            Application.Run(form1);
        }
    }
}