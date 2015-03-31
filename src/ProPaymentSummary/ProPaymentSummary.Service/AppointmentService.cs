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
    public class AppointmentService : IAppointmentService
    {
        public IQueryable<AppointmentDto> GetAppointments()
        {
            //return Uow.Appointments.Select(x => new AppointmentDto(){}};
            throw new NotImplementedException();
        }

        public void Create(AppointmentData appointmentData)
        {
            //var appointment = Mapper.Map(appointmentData);
            //Uow.Appointment.Add(appointment);
            //Uow.Commit();
        }
    }
}
