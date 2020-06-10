using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace APIGateway
{
    public class Program
    {
        //private static object config;

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().ConfigureAppConfiguration((hostingContext, config) => { config.AddJsonFile("ocelot.json"); });
        }
        //.ConfigureWebHostDefaults(WebHostBuilder => { })
        // .UseStartup<Startup>();
    }
}
