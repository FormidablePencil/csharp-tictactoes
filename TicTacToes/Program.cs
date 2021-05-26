using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TicTacToes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1233422@23");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
            Console.WriteLine("1233422@23");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
