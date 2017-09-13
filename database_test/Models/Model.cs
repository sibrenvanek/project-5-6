using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace database_test.Models
{
    public class testContext : DbContext
    {
        public DbSet<Test> Tests {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=project56;Password=project56;Host=localhost;Port=5432;Database=Test;Pooling=true;");
        }
    }
    public class Test
    {
        public int TestId {get; set;}
        public string Name {get; set;}
    }
}