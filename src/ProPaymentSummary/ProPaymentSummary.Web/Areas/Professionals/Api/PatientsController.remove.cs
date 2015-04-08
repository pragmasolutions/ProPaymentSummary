//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.OData.Query;
//using System.Web.OData;
//using ProPaymentSummary.Entities;
//using ProPaymentSummary.Service;
//using ProPaymentSummary.Service.Data;
//using ProPaymentSummary.Service.Interfaces;

//namespace ProPaymentSummary.Web.Areas.Professionals.Api
//{
//    public class PatientsController : ODataController
//    {
//        private readonly IPatientService _patientService;

//        public PatientsController(IPatientService patientService)
//        {
//            _patientService = patientService;
//        }

//        public PatientsController()
//            : this(new PatientService())
//        {
//        }

//        public async Task<IHttpActionResult> Post(PatientData patientData)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            await _patientService.Create(patientData);

//            return Created(patientData);
//        }
//    }
//}
