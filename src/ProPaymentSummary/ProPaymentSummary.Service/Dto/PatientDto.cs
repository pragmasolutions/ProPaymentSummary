using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Service.Dto
{
    public class PatientDto
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string DNI { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
