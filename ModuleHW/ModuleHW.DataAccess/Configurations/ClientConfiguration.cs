using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleHW.DataAccess.Models;

namespace ModuleHW.DataAccess.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("ClientId").ValueGeneratedOnAdd();

            builder.Property(c => c.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(c => c.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Company).HasColumnName("Company").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Location).HasColumnName("Location").HasMaxLength(150).IsRequired();

            builder.HasData(new List<Client>()
            {
                new Client() { Id = 1, FirstName = "Andrew", LastName = "Babashev", Company = "Apple", Location = "One Apple Park Way, Cupertino, California, U.S.", },
                new Client() { Id = 2, FirstName = "Dave", LastName = "Cunningham", Company = "Google", Location = "1600 Amphitheatre Parkway, Mountain View, California, U.S.", },
                new Client() { Id = 3, FirstName = "Everett", LastName = "Grunz", Company = "Microsoft", Location = "One Microsoft Way, Redmond, Washington, U.S.", },
                new Client() { Id = 4, FirstName = "Ian", LastName = "Fleming", Company = "Panasonic", Location = "Kadoma, Osaka, Japan", },
                new Client() { Id = 5, FirstName = "Henry", LastName = "Jones", Company = "Samsung", Location = "40th floor Samsung Electronics Building, 11, Seocho-daero 74-gil, Seocho District, Seoul, South Korea", },
            });
        }
    }
}
