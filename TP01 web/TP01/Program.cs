using TP01.repository;
using Microsoft.AspNetCore.Hosting;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCsv book = new BookCsv();

            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}
