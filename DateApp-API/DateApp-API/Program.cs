using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateApp_API.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DateApp_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var host =CreateHostBuilder(args).Build();
            // using(var scope=host.Services.CreateScope())
            // {
            //   var services=scope.ServiceProvider;
            //   try
            //   {
            //       var context=services.GetRequiredService<DataContext>();
            //       context.Database.Migrate();
            //       Seed.SeedUsers(context);
            //   }
            //   catch (System.Exception)
            //   {
                  
            //       throw;
            //   }
            // }
            // host.Run();

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
