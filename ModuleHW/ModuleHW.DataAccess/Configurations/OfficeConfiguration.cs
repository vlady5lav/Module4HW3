using System.Collections.Generic;
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

            builder.Property(o => o.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
            builder.Property(o => o.Title).HasColumnName("Title").HasMaxLength(100).IsRequired();
            builder.Property(o => o.Location).HasColumnName("Location").HasMaxLength(100).IsRequired();

            builder.HasData(new List<Office>()
            {
                new Office() { Id = 1, Name = "Office 1", Title = "Title of Office 1", Location = "Office 1 Location" },
                new Office() { Id = 2, Name = "Office 2", Title = "Title of Office 2", Location = "Office 2 Location" },
                new Office() { Id = 3, Name = "Office 3", Title = "Title of Office 3", Location = "Office 3 Location" },
                new Office() { Id = 4, Name = "Office 4", Title = "Title of Office 4", Location = "Office 4 Location" },
                new Office() { Id = 5, Name = "Office 5", Title = "Title of Office 5", Location = "Office 5 Location" },
                new Office() { Id = 6, Name = "Office 6", Title = "Title of Office 6", Location = "Office 6 Location" },
            });
        }
    }
}
