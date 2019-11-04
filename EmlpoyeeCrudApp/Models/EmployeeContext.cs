using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmlpoyeeCrudApp.Models;

namespace EmlpoyeeCrudApp.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base (options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Employee>()
                .HasKey(c=> c.EmployeeId);
            }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<EmployeeViewModel> EmployeeViewModel { get; set; }
    }
}
