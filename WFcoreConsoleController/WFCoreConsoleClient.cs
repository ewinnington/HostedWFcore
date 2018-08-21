using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace Eric.HostedWFCore.Client
{
    class WFCoreConsoleClient
    {
        public static HubConnection _connection;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Ready to connect, press any key"); 
            Console.ReadKey();
            _connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/myHub")
                .Build();

            await _connection.StartAsync();
            _connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                Console.WriteLine($"{user}: {message}");
            });

           

            await _connection.InvokeAsync("Send", "userIsMe", "This is my message");

            Console.ReadKey(); 
        }
      
    }
}



