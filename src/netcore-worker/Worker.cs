using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> Logger;

        public Worker(ILogger<Worker> logger,
            IConfiguration configuration)
        {
            Logger = logger;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var delay = string.IsNullOrEmpty(Configuration["DELAY"]) 
                ? 1000 : Convert.ToInt32(Configuration["DELAY"]);

            while (!stoppingToken.IsCancellationRequested)
            {
                Logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(delay, stoppingToken);
            }
        }
    }
}
