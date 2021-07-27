using System;
using System.Collections.Generic;
using System.Text;
using CargoService_API_Sachin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CargoService_API_Sachin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
