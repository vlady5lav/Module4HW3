using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleHW.DataAccess.Models;

namespace ModuleHW.DataAccess.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ProjectId").ValueGeneratedOnAdd();

            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Budget).HasColumnName("Budget").HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasPrecision(7).IsRequired();

            builder.HasOne(p => p.Client).WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId).OnDelete(DeleteBehavior.Cascade).IsRequired();

            builder.HasData(new List<Project>()
            {
                new Project() { Id = 1, Name = "Anaconda", Budget = 10000.0M, ClientId = 1, StartedDate = new DateTime(2021, 11, 01), },
                new Project() { Id = 2, Name = "Cyclon", Budget = 20000.0M, ClientId = 2, StartedDate = new DateTime(2021, 11, 02), },
                new Project() { Id = 3, Name = "Drager", Budget = 30000.0M, ClientId = 3, StartedDate = new DateTime(2021, 11, 03), },
                new Project() { Id = 4, Name = "Golum", Budget = 40000.0M, ClientId = 4, StartedDate = new DateTime(2021, 11, 04), },
                new Project() { Id = 5, Name = "Oblivion", Budget = 50000.0M, ClientId = 5, StartedDate = new DateTime(2021, 11, 05), },
                new Project() { Id = 6, Name = "Raptor", Budget = 60000.0M, ClientId = 5, StartedDate = new DateTime(2021, 11, 06), },
            });
        }
    }
}
