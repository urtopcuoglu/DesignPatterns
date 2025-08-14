using DesignPattern.ChainOfResponsibility.DAT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AA5GSTT;Database=DesignPatterns;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
            //Server=DESKTOP-AA5GSTT;Database=;Trusted_Connection=True;
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
