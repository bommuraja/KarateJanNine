﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_ContextClass
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BommurajaDBEntities : DbContext
    {
        public BommurajaDBEntities()
            : base("name=BommurajaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Photo_Details> Photo_Details { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SchemeMaster> SchemeMasters { get; set; }
    }
}
