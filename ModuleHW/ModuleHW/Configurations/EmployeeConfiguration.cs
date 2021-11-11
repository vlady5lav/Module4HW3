using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleHW.Models;

namespace ModuleHW.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("EmployeeId").ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(e => e.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(e => e.HiredDate).HasColumnName("HiredDate").HasPrecision(7).IsRequired();
            builder.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date").IsRequired(false);

            builder.HasOne(e => e.Office).WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Title).WithMany(t => t.Employees)
                .HasForeignKey(e => e.TitleId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
