using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SaleOrderExceptionHandler
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration Configuration;

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //Log.Information("Worker SALEORDER EXCEPTION HANDLER started");

            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    SaleOrder saleOrderLogic = new SaleOrder(Configuration["DatabaseConnection"]);

            //    // Cảnh báo đơn hàng chưa xuất
            //    List<SaleOrder> saleOrders = saleOrderLogic.GetTimeoutList(60);
            //    if (saleOrders.Count > 0)
            //        Log.Fatal($"CÓ {saleOrders.Count} ĐƠN HÀNG PENDING, CHƯA XUẤT");

            //    await Task.Delay(Convert.ToInt32(Configuration["CheckIntervalSecond"]) * 1000, stoppingToken);
            //}
        }
    }
}
