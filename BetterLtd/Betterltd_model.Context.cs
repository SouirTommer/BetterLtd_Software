﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterLtd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class betterltdEntities : DbContext
    {
        public betterltdEntities()
            : base("name=betterltdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<acc> accs { get; set; }
        public virtual DbSet<activitylog> activitylogs { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<deliveryorder> deliveryorders { get; set; }
        public virtual DbSet<installorder> installorders { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<retailstore> retailstores { get; set; }
        public virtual DbSet<salesorder> salesorders { get; set; }
        public virtual DbSet<salesorder_detail> salesorder_detail { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<store_reorder> store_reorder { get; set; }
        public virtual DbSet<store_stock> store_stock { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }
        public virtual DbSet<warehouse_reorder> warehouse_reorder { get; set; }
        public virtual DbSet<warehouse_stock> warehouse_stock { get; set; }
        public virtual DbSet<payment> payments { get; set; }
    }
}
