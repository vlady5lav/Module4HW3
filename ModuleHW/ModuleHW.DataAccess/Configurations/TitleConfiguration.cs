using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleHW.DataAccess.Models;

namespace ModuleHW.DataAccess.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("TitleId").ValueGeneratedOnAdd();

            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
        }
    }
}
