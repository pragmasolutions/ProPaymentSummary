using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProPaymentSummary.Entities;

namespace ProPaymentSummary.Data.Interfaces
{
    public interface IProPaymentSummaryUow : IDisposable
    {
        IRepository<HealthInsuranceProvider> HealthInsuranceProviders { get; }
        IRepository<Appointment> Appointments { get; }
        IRepository<Patient> Patients { get; }
        IRepository<Practice> Practices { get; }
        IRepository<PracticeAppointment> PracticeAppointments { get; }
        IRepository<Professional> Professionals { get; }
        IRepository<Province> Provinces { get; }

        void Commit();
    }
}
