﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProPaymentSummary.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProPaymentSummaryEntities : DbContext
    {
        public ProPaymentSummaryEntities()
            : base("name=ProPaymentSummaryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<HealthInsuranceProvider> HealthInsuranceProviders { get; set; }
        public virtual DbSet<HealthInsuranceProviderPlan> HealthInsuranceProviderPlans { get; set; }
        public virtual DbSet<MedicalOrder> MedicalOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Practice> Practices { get; set; }
        public virtual DbSet<PracticeAppointment> PracticeAppointments { get; set; }
        public virtual DbSet<PracticeOrder> PracticeOrders { get; set; }
        public virtual DbSet<Professional> Professionals { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
    }
}
