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
        }
    }
}
