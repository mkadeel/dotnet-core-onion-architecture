using Microsoft.EntityFrameworkCore;
using Onion.Entities.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Item> Items { get; set; }


    }
}
