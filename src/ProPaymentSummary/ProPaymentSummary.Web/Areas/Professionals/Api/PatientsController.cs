using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using ProPaymentSummary.Service.Dto;
using Microsoft.Data.OData;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Interfaces;
using ProPaymentSummary.Service;

namespace ProPaymentSummary.Web.Areas.Professionals.Api
{
    public class PatientsController : ODataController
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public PatientsController()
            : this(new PatientService())
        {
        }

        // POST: odata/Patients
        public async Task<IHttpActionResult> Post(PatientData patientData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _patientService.Create(patientData);

            return Created(patientData);
        }
    }
}
