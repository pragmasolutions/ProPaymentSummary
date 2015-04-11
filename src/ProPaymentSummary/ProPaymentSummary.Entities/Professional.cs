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
    
    public partial class Professional
    {
        public string ProfessionalId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CUIT { get; set; }
        public int DNI { get; set; }
        public string MP { get; set; }
        public string MN { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public string City { get; set; }
        public byte[] ProfileImage { get; set; }
    
        public virtual Province Province { get; set; }
    }
}
