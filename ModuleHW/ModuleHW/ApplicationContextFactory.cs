using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ModuleHW
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var configFile = "appsettings.json";
            var configFileInfo = new FileInfo(configFile);

            if (configFileInfo.Exists)
            {
                // IConfiguration configuration = new ConfigurationBuilder().AddJsonFile(configFile).Build();
                // var connectionString = configuration.GetConnectionString("SuperTestDB123");

                var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
                // dbContextOptionsBuilder.UseSqlServer(connectionString);
                dbContextOptionsBuilder.UseSqlServer("Data Source=blog.db");

                return new ApplicationContext(dbContextOptionsBuilder.Options);
            }
            else
            {
                Console.WriteLine($"ERROR! There is no config file \"{configFile}\" provided!");
                Environment.Exit(0);
                return null;
            }
        }
    }
}
