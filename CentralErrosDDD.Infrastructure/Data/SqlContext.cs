using Microsoft.EntityFrameworkCore;
using CentralErrosDDD.Domain.Entitys;
using System;
using System.Linq;

namespace CentralErrosDDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }
        public DbSet<ErrorOcurrence> ErrorOcurrence { get; set; }

        public DbSet<Domain.Entitys.Environment> Environment { get; set; }

        public DbSet<Level> Level { get; set; }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("createdAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("createdAt").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("createdAt").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}