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
    
    public partial class PracticeOrder
    {
        public int PracticeOrderId { get; set; }
        public int PracticeId { get; set; }
        public int OrderId { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Practice Practice { get; set; }
    }
}
