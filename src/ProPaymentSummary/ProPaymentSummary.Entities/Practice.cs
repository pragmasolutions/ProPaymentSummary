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
    
    public partial class Practice
    {
        public Practice()
        {
            this.PracticeOrders = new HashSet<PracticeOrder>();
        }
    
        public int PracticeId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public string Nomenclator { get; set; }
        public decimal UB { get; set; }
    
        public virtual ICollection<PracticeOrder> PracticeOrders { get; set; }
    }
}
