using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Scheduler.Controllers;
using Scheduler.Services.Interfaces;

namespace Scheduler.Services
{
    public class ScheduledService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public ScheduledService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var controllerFactoryService = scope.ServiceProvider.GetRequiredService<HomeController>();

                    // Create the controller instance
                    var result = controllerFactoryService.GetHello();
                    
                    // Call the controller method
                    //var result = controller.GetHello();

                    // Handle the result (e.g., log it, etc.)
                    Console.WriteLine($"Task running in background {DateTime.Now}"); // For demonstration
                }

                // Wait for 1 minute before the next execution
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}