using Microsoft.EntityFrameworkCore;
using net_Oponeo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_Oponeo
{
    public class DbTestContext : DbContext
    {
        public DbTestContext(DbContextOptions<DbTestContext> options) : base(options) { }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<Rim> Rims { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
