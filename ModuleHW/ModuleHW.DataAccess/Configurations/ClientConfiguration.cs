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
            builder.Property(c => c.Email).HasColumnName("Email").HasMaxLength(150).IsRequired();
            builder.Property(c => c.Company).HasColumnName("Company").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Location).HasColumnName("Location").HasMaxLength(150).IsRequired();

            builder.HasData(new List<Client>()
            {
                new Client() { Id = 1, FirstName = "Andrew [1]", LastName = "Babashev [1]", Email = "client_1@ma.il", Company = "Apple", Location = "One Apple Park Way, Cupertino, California, U.S.", },
                new Client() { Id = 2, FirstName = "Dave [2]", LastName = "Cunningham [2]", Email = "client_2@ma.il", Company = "Google", Location = "1600 Amphitheatre Parkway, Mountain View, California, U.S.", },
                new Client() { Id = 3, FirstName = "Everett [3]", LastName = "Grunz [3]", Email = "client_3@ma.il", Company = "Microsoft", Location = "One Microsoft Way, Redmond, Washington, U.S.", },
                new Client() { Id = 4, FirstName = "Ian [4]", LastName = "Fleming [4]", Email = "client_4@ma.il", Company = "Panasonic", Location = "Kadoma, Osaka, Japan", },
                new Client() { Id = 5, FirstName = "Henry [5]", LastName = "Jones [5]", Email = "client_5@ma.il", Company = "Samsung", Location = "40th floor Samsung Electronics Building, 11, Seocho-daero 74-gil, Seocho District, Seoul, South Korea", },
                new Client() { Id = 6, FirstName = "Volt [6]", LastName = "Querier [6]", Email = "client_6@ma.il", Company = "VQ", Location = "VQ Location", },
            });
        }
    }
}
