﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webshop2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class new_testEntities : DbContext
    {
        public new_testEntities()
            : base("name=new_testEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<aspnetroles> aspnetroles { get; set; }
        public virtual DbSet<aspnetuserclaims> aspnetuserclaims { get; set; }
        public virtual DbSet<aspnetuserlogins> aspnetuserlogins { get; set; }
        public virtual DbSet<aspnetusers> aspnetusers { get; set; }
        public virtual DbSet<@case> @case { get; set; }
        public virtual DbSet<chat> chat { get; set; }
        public virtual DbSet<cpucooler> cpucooler { get; set; }
        public virtual DbSet<gpu> gpu { get; set; }
        public virtual DbSet<internalharddisk> internalharddisk { get; set; }
        public virtual DbSet<motherboard> motherboard { get; set; }
        public virtual DbSet<powersupply> powersupply { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<ram> ram { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<shoppingcart> shoppingcart { get; set; }
        public virtual DbSet<ssd> ssd { get; set; }
        public virtual DbSet<supplier> supplier { get; set; }
        public virtual DbSet<wishlist> wishlist { get; set; }
    }
}
