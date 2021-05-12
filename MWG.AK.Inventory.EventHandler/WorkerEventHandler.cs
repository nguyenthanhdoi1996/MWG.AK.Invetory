using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.EventHandler
{
    public class WorkerEventHandler : BackgroundService
    {
        private readonly ILogger<WorkerEventHandler> _logger;
        private readonly IConfiguration Configuration;

        public WorkerEventHandler(ILogger<WorkerEventHandler> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Worker SALEORDER EVENT HANDLER started");
            Log.Information("Worker SALEORDER EVENT HANDLER started");

            var conf = new ConsumerConfig
            {
                BootstrapServers = Configuration["KafkaBrokers"],
                GroupId = Configuration["ConsumerGroupName"],
                // Note: The AutoOffsetReset property determines the start offset in the event
                // there are not yet any committed offsets for the consumer group for the
                // topic/partitions of interest. By default, offsets are committed
                // automatically, so in this example, consumption will only start from the
                // earliest message in the topic 'my-topic' the first time you run the program.
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using (var c = new ConsumerBuilder<Ignore, string>(conf).Build())
            {
                c.Subscribe(Configuration["ConsumeTopic"]);

                CancellationTokenSource cts = new CancellationTokenSource();
                Console.CancelKeyPress += (_, e) =>
                {
                    e.Cancel = true; // prevent the process from terminating.
                    cts.Cancel();
                };

                try
                {
                    while (true)
                    {
                        try
                        {
                            var cr = c.Consume(cts.Token);

                            //Console.WriteLine($"Consumed message '{cr.Message.Value}' at: '{cr.TopicPartitionOffset}'.");

                            dynamic obj = JsonConvert.DeserializeObject(cr.Message.Value);
                            string SaleOrderID = Convert.ToString(obj.SaleOrderID);
                            int OutputStoreID = Convert.ToInt32(obj.OutputStoreID);

                            // Cập nhật trạng thái "Đã xuất hàng" cho đơn hàng
                            //SaleOrder objSO = new SaleOrder(Configuration["DatabaseConnection"]);
                            //string SOID = objSO.UpdateOutputStatus(SaleOrderID, OutputStoreID);

                            Exception kafkaMessage = new Exception(cr.Message.Value);
                            //Log.Information(kafkaMessage, $"Worker SALEORDER EVENT HANDLER consumed message, SaleOrder {SOID} has outputed.");
                            //Console.WriteLine($"Worker SALEORDER EVENT HANDLER consumed message, SaleOrder {SOID} has outputed.");
                        }
                        catch (ConsumeException e)
                        {
                            Log.Error(e, $"Error occured: {e.Error.Reason}");
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    // Ensure the consumer leaves the group cleanly and final offsets are committed.
                    c.Close();
                }
            }
        }
    }
}
