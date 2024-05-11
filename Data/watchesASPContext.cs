using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using watchesASP.Api.Entities;

namespace watchesASP.Api.Data
{
    public class watchesASPContext(DbContextOptions<watchesASPContext> options)
    : DbContext(options)
    {
        public DbSet<Watch> Watches => Set<Watch>();

        public DbSet<MovType> Types => Set<MovType>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovType>().HasData(
                new { Id = 1, Name = "Automatic" },
                new { Id = 2, Name = "Mechanical" },
                new { Id = 3, Name = "Quartz" }

            );
        }
    }
}