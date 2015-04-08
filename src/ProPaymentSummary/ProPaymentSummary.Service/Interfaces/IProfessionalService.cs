using ProPaymentSummary.Entities;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Service.Interfaces
{
    public interface IProfessionalService
    {
        ProfessionalDto Get(string id);
    }
}
