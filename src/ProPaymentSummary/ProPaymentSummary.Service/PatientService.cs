using System.Threading.Tasks;
using AutoMapper;
using ProPaymentSummary.Entities;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Interfaces;

namespace ProPaymentSummary.Service
{
    public class PatientService : BaseService, IPatientService
    {
        public async Task Create(PatientData patientData)
        {
            var patient = Mapper.Map<PatientData, Patient>(patientData);
            Uow.Patients.Add(patient);
            Uow.Commit();
        }
    }
}
