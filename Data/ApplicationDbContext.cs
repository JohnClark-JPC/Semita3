using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Semita3.Models;

namespace Semita3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Semita3.Models.Project> Project { get; set; }
        public DbSet<Semita3.Models.Ticket> Ticket { get; set; }
        public DbSet<Semita3.Models.Employee> Employee { get; set; }
    }
}
