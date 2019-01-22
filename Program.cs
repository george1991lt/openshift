using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;

namespace WebApplication1
{
    var url = config["ASPNETCORE_URLS"] ??
        "http://*:8080";
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            ConfigurationBuilder().AddEnvironmentVariables("").Build();
        }
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(url)
                .Build();
    }
}
