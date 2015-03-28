using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Service.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string HealthInsuranceProviderName { get; set; }
        public string PatientName { get; set; }
        public string PatientDNI { get; set; }
        public DateTime AttentionDate { get; set; }
    }
}
