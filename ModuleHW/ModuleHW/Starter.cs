using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModuleHW.DataAccess;

namespace ModuleHW.StartApplication
{
    public class Starter
    {
        public void Run()
        {
            var configFile = "appsettings.json";
            var configFileInfo = new FileInfo(configFile);

            if (configFileInfo.Exists)
            {
                IConfiguration configuration = new ConfigurationBuilder().AddJsonFile(configFile).Build();
                var connectionString = configuration.GetConnectionString("SuperTestDB123");

                var serviceProvider = new ServiceCollection()
                    .AddTransient<ApplicationContext>()
                    .AddDbContext<ApplicationContext>(s => s.UseSqlServer(connectionString, s => s.CommandTimeout(30)))
                    .BuildServiceProvider();

                using var db = serviceProvider.GetService<ApplicationContext>();

                db.Database.Migrate();
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"ERROR! There is no config file \"{configFile}\" provided!");
                Environment.Exit(0);
            }
        }
    }
}
