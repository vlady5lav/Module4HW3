using System.Collections.Generic;
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

            builder.HasData(new List<Title>()
            {
                new Title() { Id = 1, Name = "Title 1" },
                new Title() { Id = 2, Name = "A title 2" },
                new Title() { Id = 3, Name = "Title 3" },
                new Title() { Id = 4, Name = "Title 4" },
                new Title() { Id = 5, Name = "A title 5" },
                new Title() { Id = 6, Name = "A Title 6" },
            });
        }
    }
}
