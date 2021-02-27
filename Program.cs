using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea1DWBE.DataAccess;

namespace Tarea1DWBE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        
        public static void Tarea1()
        {
            // select * from Employee
            NorthwindContext dataContext = new NorthwindContext();

            var employeeQuery = dataContext.Employees.Select(s => s).AsQueryable();
            var output = employeeQuery.ToList();

        }
    }
}
