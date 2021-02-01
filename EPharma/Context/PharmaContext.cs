using EPharma.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPharma.Context
{
    public class PharmaContext : DbContext
    {
        public PharmaContext(DbContextOptions<PharmaContext> options) : base(options) { }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Plans> Plans { get; set; }
        public DbSet<ClientPlan> ClientPlans { get; set; }
    }
}
