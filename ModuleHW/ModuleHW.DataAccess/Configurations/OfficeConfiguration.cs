using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleHW.DataAccess.Models;

namespace ModuleHW.DataAccess.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.Id);

            builder.Property(o => o.Id).HasColumnName("OfficeId").ValueGeneratedOnAdd();

            builder.Property(o => o.Title).HasColumnName("Title").HasMaxLength(100).IsRequired();
            builder.Property(o => o.Location).HasColumnName("Location").HasMaxLength(100).IsRequired();
        }
    }
}
