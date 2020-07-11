using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseKestrel()
                    //.UseWebRoot("MyContantFolder") // use this name instead of folder wwwroot
                    //.UseIISIntegration();

                    webBuilder.UseStartup<Startup>();
                 /*  .ConfigureAppConfiguration((hostingContext, config) =>
                    {

                        var env = hostingContext.HostingEnvironment;
                        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                        if (env.IsDevelopment())
                        {
                            var appAsembly = Assembly.Load(new AssemblyName(env.ApplicationName));
                            config.AddUserSecrets(appAsembly, optional: true);
                        }

                        config.AddEnvironmentVariables();
                        if (args != null)
                        {
                            config.AddCommandLine(args);
                    }
                    })
                    .ConfigureLogging((hostingContext, logging) => {
                        logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                        logging.AddConsole();
                        logging.AddDebug();
                        var message = hostingContext.Configuration.GetSection("MySecretKey").Value;
                    });

                   */
                });
    }
}
