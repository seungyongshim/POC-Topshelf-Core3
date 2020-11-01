using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Topshelf.Extensions.Hosting;


namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddHostedService<AkkaHostedService>();
                })
                
                .UseTopshelfLifetime()
                .RunAsTopshelfService(hc =>
                {
                    hc.SetServiceName("GenericHostInTopshelf");
                    hc.SetDisplayName("Generic Host In Topshelf");
                    hc.SetDescription("Runs a generic host as a Topshelf service.");
                });
        }
    }
}
