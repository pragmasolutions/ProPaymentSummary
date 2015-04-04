using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProPaymentSummary.Entities;
using ProPaymentSummary.Service.Data;

namespace ProPaymentSummary.Web.Api
{
    public class ProfessionalController : ApiController
    {
        public string Get()
        {
            return "hola vithe";
        }

        public void Post(PatientData data)
        {
            Ok();
        }
    }
}
