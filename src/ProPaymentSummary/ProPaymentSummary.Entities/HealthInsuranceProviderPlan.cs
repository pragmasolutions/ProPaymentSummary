//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class HealthInsuranceProviderPlan
    {
        public HealthInsuranceProviderPlan()
        {
            this.MedicalOrders = new HashSet<MedicalOrder>();
        }
    
        public int HealthInsuranceProviderPlanId { get; set; }
        public int HealthInsuranceProviderId { get; set; }
        public byte[] Name { get; set; }
    
        public virtual HealthInsuranceProvider HealthInsuranceProvider { get; set; }
        public virtual ICollection<MedicalOrder> MedicalOrders { get; set; }
    }
}