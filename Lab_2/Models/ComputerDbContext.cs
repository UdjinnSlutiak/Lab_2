using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2.Models;

namespace Lab_2.Models
{
    public class ComputerDbContext : DbContext
    {
        
        public ComputerDbContext(DbContextOptions<ComputerDbContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Computer> Computers { get; set; }

        public DbSet<Lab_2.Models.AddViewModel> AddViewModel { get; set; }
    }
}
