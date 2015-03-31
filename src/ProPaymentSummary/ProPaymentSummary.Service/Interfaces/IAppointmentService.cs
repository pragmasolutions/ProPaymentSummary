using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Service.Interfaces
{
    public interface IAppointmentService
    {
        IQueryable<AppointmentDto> GetAppointments();
        void Create(AppointmentData appointmentData);
    }
}
