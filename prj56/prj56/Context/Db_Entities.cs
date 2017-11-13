using prj56.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace prj56.Context

{


    public class Db_Entities : DbContext, IDisposable //db context
    {
        public Db_Entities() : base(nameOrConnectionString: "server=10.0.0.208;user id=Admin;password=Admin;database=local_db") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Customer>().MapToStoredProcedures();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Case> Cases { get; set; }//Migrated
        public DbSet<CPUCooler> CpuCoolers { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<InternalHDD> HDDs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<SSD> SSDs { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; } //<- not yet migrated , FK
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Chat> Chat { get; set; }

    }
}