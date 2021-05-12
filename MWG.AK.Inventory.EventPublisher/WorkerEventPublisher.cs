using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MWG.AK.Inventory.BLL.EventLog;
using MWG.AK.Inventory.DAO.Entities;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.EventPublisher
{
    public class WorkerEventPublisher : BackgroundService
    {
        private readonly ILogger<WorkerEventPublisher> _logger;
        private readonly IConfiguration Configuration;
        private IEventLogDAO _eventLogDAO;

        public WorkerEventPublisher(ILogger<WorkerEventPublisher> logger, IConfiguration configuration, IEventLogDAO eventLogDAO)
        {
            _logger = logger;
            Configuration = configuration;
            _eventLogDAO = eventLogDAO;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Log.Information("Worker MWG.AK.Inventory EVENT PUBLISHER started");

            while (!stoppingToken.IsCancellationRequested)
            {
                // Lấy danh sách các event chưa publish
                List<system_eventlog> objEventLogs = _eventLogDAO.GetUnPublishedEventList(Configuration["EventType"]);

                // Publish event ra Message Bus
                var conf = new ProducerConfig
                {
                    BootstrapServers = Configuration["KafkaBrokers"]
                    //,Acks = Acks.None
                };

                using (var p = new ProducerBuilder<Null, string>(conf).Build())
                {
                    string lastTopicPartitionOffset = "";

                    foreach (system_eventlog objEventLog in objEventLogs)
                    {
                        try
                        {
                            // Publish Event message
                            var dr = await p.ProduceAsync(Configuration["PublishTopic"], new Message<Null, string> { Value = JsonConvert.SerializeObject(objEventLog) });

                            // Chuyển EventState = PUBLISHED
                            _eventLogDAO.SetStateToPublished(objEventLog.eventid);

                            lastTopicPartitionOffset = dr.TopicPartitionOffset.ToString();
                        }
                        catch (ProduceException<Null, string> e)
                        {
                            Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                        }
                    }

                    // wait for up to 10 seconds for any inflight messages to be delivered.
                    p.Flush(TimeSpan.FromSeconds(10));
                    //Console.WriteLine($"{MessageCount} send in {DateTime.Now.Subtract(t).TotalMilliseconds}, last TopicPartitionOffset = [{lastTopicPartitionOffset}]");
                }

                //_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                // Nếu KHÔNG có event thì SLEEP từ 5 - 20 giây
                if (objEventLogs.Count == 0)
                {
                    int sleepSeconds = new Random().Next(5, 20);
                    Console.WriteLine($"No event need to publish, sleeping {sleepSeconds} seconds");
                    await Task.Delay(sleepSeconds * 1000, stoppingToken);
                }
                else
                {
                    Log.Information($"Worker SALEORDER EVENT PUBLISHER has published {objEventLogs.Count} event message(s)");
                }
            }
        }
    }
}
