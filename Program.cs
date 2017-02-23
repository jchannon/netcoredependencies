using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace netcore11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://+:5000")
                .UseKestrel()
                .Build();

            host.Run();
        }
    }
}
