using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.EventPublisher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Logging config

            // add this for logging
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // add this for logging
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration, "Serilog")
                .Enrich.FromLogContext()
                .CreateLogger();

            #endregion

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<WorkerEventPublisher>();
                });
    }
}
