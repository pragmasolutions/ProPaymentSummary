using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Service.Dto
{
    public class ProfessionalDto
    {
        public string Id { get; set; }
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
    }
}
