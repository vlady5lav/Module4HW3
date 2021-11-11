using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ModuleHW.Configurations;
using ModuleHW.Models;

namespace ModuleHW
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configFile = new FileInfo("settings.json");

            if (configFile.Exists)
            {
                IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("settings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("SuperTestDB123"));
            }
            else
            {
                Console.WriteLine("ERROR! There is no config file \"settings.json\" provided!");
                Environment.Exit(0);
            }
        }
    }
}
