using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleHW.DataAccess.Models;

namespace ModuleHW.DataAccess.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(ep => ep.Id);

            builder.Property(ep => ep.Id).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();

            builder.Property(ep => ep.Rate).HasColumnName("Rate").HasColumnType("money").IsRequired();
            builder.Property(ep => ep.StartedDate).HasColumnName("StartedDate").IsRequired().HasPrecision(7);

            builder.HasOne(ep => ep.Employee).WithMany(e => e.EmployeeProject)
                .HasForeignKey(ep => ep.EmployeeId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(ep => ep.Project).WithMany(p => p.EmployeeProject)
                .HasForeignKey(ep => ep.ProjectId).OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<EmployeeProject>()
            {
                new EmployeeProject() { Id = 1, EmployeeId = 1, ProjectId = 5, Rate = 3000M, StartedDate = System.DateTime.Today.AddDays(-60), },
                new EmployeeProject() { Id = 2, EmployeeId = 2, ProjectId = 4, Rate = 4000M, StartedDate = System.DateTime.Today.AddDays(-50), },
                new EmployeeProject() { Id = 3, EmployeeId = 3, ProjectId = 3, Rate = 5000M, StartedDate = System.DateTime.Today.AddDays(-40), },
                new EmployeeProject() { Id = 4, EmployeeId = 4, ProjectId = 2, Rate = 6000M, StartedDate = System.DateTime.Today.AddDays(-30), },
                new EmployeeProject() { Id = 5, EmployeeId = 5, ProjectId = 1, Rate = 7000M, StartedDate = System.DateTime.Today.AddDays(-20), },
                new EmployeeProject() { Id = 6, EmployeeId = 5, ProjectId = 6, Rate = 8000M, StartedDate = System.DateTime.Today.AddDays(-10), },
            });
        }
    }
}
