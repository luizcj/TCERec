﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALTCE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TCEREDXEntities : DbContext
    {
        public TCEREDXEntities()
            : base("name=TCEREDXEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SequencialGed> SequencialGeds { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Guia> Guias { get; set; }
        public virtual DbSet<TDummy> TDummies { get; set; }
        public virtual DbSet<Processo> Processoes { get; set; }
    }
}
