﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityAspProject.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class UdemyProductTrackingEntities : DbContext
    {
        public UdemyProductTrackingEntities()
            : base("name=UdemyProductTrackingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_category> tbl_category { get; set; }
        public virtual DbSet<tbl_customer> tbl_customer { get; set; }
        public virtual DbSet<tbl_product> tbl_product { get; set; }
        public virtual DbSet<tbl_sale> tbl_sale { get; set; }
        public virtual DbSet<tbl_staff> tbl_staff { get; set; }
    
        public virtual ObjectResult<string> ctgCount()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ctgCount");
        }
    }
}
