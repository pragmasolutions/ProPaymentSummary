using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using ProPaymentSummary.Entities;
using ProPaymentSummary.Service;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Dto;
using ProPaymentSummary.Service.Interfaces;

namespace ProPaymentSummary.Web.Api
{
    public class ProfessionalController : ApiController
    {
        private readonly IProfessionalService _professionalService;

        public ProfessionalController(IProfessionalService professionalService)
        {
            _professionalService = professionalService;
        }

        public ProfessionalController()
            : this(new ProfessionalService())
        {
        }

        [HttpGet]
        public ProfessionalDto GetCurrent()
        {
            //var prof = _professionalService.Get(User.Identity.GetUserId());
            //return prof;

            return null;
        }

        [HttpPost]
        public void Post(FormCollection collection)
        {
            Ok();
        }
    }
}
