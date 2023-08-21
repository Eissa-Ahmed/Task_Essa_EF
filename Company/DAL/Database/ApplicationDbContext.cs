using Company.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Database
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = ESSA-AHMED; Integrated Security = True; initial catalog = Company; Trust Server Certificate = true; ");
        }
        DbSet<Employees> employees { get; set; }
        DbSet<DepartMent> departMents { get; set; }
    }
}
