using Eric.HostedWFCore.Server.ServiceBasics;
using Eric.HostedWFCore.Server.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


//Let's set this up as a windows service 
//https://www.stevejgordon.co.uk/running-net-core-generic-host-applications-as-a-windows-service

namespace Eric.HostedWFCore.Server
{
    class MainService
    {
        static bool IsService; 

        private static async Task Main(string[] args)
        {
            IsService = !(Debugger.IsAttached || args.Contains("--console")); //!System.Environment.UserInteractive;

            var builder = new HostBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<FileWriterService>(); 
            });

            if(IsService)
            {
                await builder.RunAsServiceAsync(); 
            }
            else
            {
                await builder.RunConsoleAsync(); 
            }
        }
    }
}
