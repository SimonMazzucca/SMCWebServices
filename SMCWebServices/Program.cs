using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SMCWebServices.DataAccess;
using System;

namespace SMCWebServices
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ///Generate Host Builder and Register the Services for DI
            IHostBuilder builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddDbContext<SmcContext>(options =>
                   {
                       options.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=ABCReports;Trusted_Connection=True;");
                   });
               });

            IHost host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SmcContext>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured: {0}", ex.Message);
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
