using System.Threading.Tasks;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Interfaces;

namespace ProPaymentSummary.Service
{
    public class PatientService : BaseService, IPatientService
    {
        public async Task Create(PatientData patientData)
        {
            //var patient = Mapper.Map<Patient, PatientData>(patientData);
            //Uow.Patients.Add();
            //Uow.Commit();
        }
    }
}
