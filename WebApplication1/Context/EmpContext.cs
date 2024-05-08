using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System;

namespace WebApplication1.Context
{
    public class EmpContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=mvc;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Marsel", Title = "Software Engineer", Age = 21 },
                new Employee { Id = 2, Name = "Alice", Title = "HR Manager", Age = 30 },
                new Employee { Id = 3, Name = "Bob", Title = "Sales Executive", Age = 25 },
                new Employee { Id = 4, Name = "John", Title = "Marketing Specialist", Age = 28 },
                new Employee { Id = 5, Name = "Emily", Title = "Accountant", Age = 27 },
                new Employee { Id = 6, Name = "David", Title = "Graphic Designer", Age = 29 },
                new Employee { Id = 7, Name = "Sophia", Title = "Project Manager", Age = 32 },
                new Employee { Id = 8, Name = "Liam", Title = "Customer Support", Age = 24 },
                new Employee { Id = 9, Name = "Olivia", Title = "Operations Manager", Age = 31 },
                new Employee { Id = 10, Name = "Michael", Title = "Software Developer", Age = 26 }
            );
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
