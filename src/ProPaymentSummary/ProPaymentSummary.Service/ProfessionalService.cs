using ProPaymentSummary.Entities;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Dto;
using ProPaymentSummary.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Service
{
    public class ProfessionalService : IProfessionalService
    {
        public IQueryable<Professional> Get(string id)
        {
            //return Uow.Appointments.Select(x => new AppointmentDto(){}};
            throw new NotImplementedException();
        }
    }
}
