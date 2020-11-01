using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    internal class AkkaHostedService : IHostedService
    {
        public AkkaHostedService(ILogger<AkkaHostedService> logger)
        {
            this.Logger = logger;
        }

        public ILogger<AkkaHostedService> Logger { get; }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Logger.LogInformation("Start");
            return Task.CompletedTask;
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            Logger.LogInformation("Stop");
            return Task.CompletedTask;

        }
    }
}
