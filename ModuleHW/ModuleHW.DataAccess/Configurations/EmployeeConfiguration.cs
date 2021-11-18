using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleHW.DataAccess.Models;

namespace ModuleHW.DataAccess.Configurations
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
                .HasForeignKey(e => e.OfficeId).OnDelete(DeleteBehavior.Cascade).IsRequired(false);
            builder.HasOne(e => e.Title).WithMany(t => t.Employees)
                .HasForeignKey(e => e.TitleId).OnDelete(DeleteBehavior.Cascade).IsRequired(false);

            builder.HasData(new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "FName [1]", LastName = "LName [1]", DateOfBirth = DateTime.Today.AddYears(-40), HiredDate = DateTime.Today.AddYears(-10), OfficeId = 1, TitleId = 1, },
                new Employee() { Id = 2, FirstName = "FName [2]", LastName = "LName [2]", DateOfBirth = DateTime.Today.AddYears(-35), HiredDate = DateTime.Today.AddYears(-8), OfficeId = 2, TitleId = 2, },
                new Employee() { Id = 3, FirstName = "FName [3]", LastName = "LName [3]", DateOfBirth = DateTime.Today.AddYears(-30), HiredDate = DateTime.Today.AddYears(-6), OfficeId = 3, TitleId = 3, },
                new Employee() { Id = 4, FirstName = "FName [4]", LastName = "LName [4]", DateOfBirth = DateTime.Today.AddYears(-25), HiredDate = DateTime.Today.AddYears(-4), OfficeId = 4, TitleId = 4, },
                new Employee() { Id = 5, FirstName = "FName [5]", LastName = "LName [5]", DateOfBirth = DateTime.Today.AddYears(-20), HiredDate = DateTime.Today.AddYears(-2), OfficeId = 5, TitleId = 5, },
                new Employee() { Id = 6, FirstName = "FName [6]", LastName = "LName [6]", DateOfBirth = DateTime.Today.AddYears(-15), HiredDate = DateTime.Today, OfficeId = 6, TitleId = 6, },
                new Employee() { Id = 7, FirstName = "FName [7]", LastName = "LName [7]", DateOfBirth = DateTime.Today.AddYears(-10), HiredDate = DateTime.Today.AddYears(-2), OfficeId = 4, },
                new Employee() { Id = 8, FirstName = "FName [8]", LastName = "LName [8]", DateOfBirth = DateTime.Today.AddYears(-5), HiredDate = DateTime.Today.AddYears(-4), TitleId = 2, },
                new Employee() { Id = 9, FirstName = "FName [9]", LastName = "LName [9]", DateOfBirth = DateTime.Today, HiredDate = DateTime.Today.AddYears(-6), },
            });
        }
    }
}
