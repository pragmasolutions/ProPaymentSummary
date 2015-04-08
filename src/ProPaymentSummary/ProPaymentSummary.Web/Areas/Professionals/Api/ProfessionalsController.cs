using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.OData;
using ProPaymentSummary.Service.Dto;
using Microsoft.Data.OData;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Interfaces;
using ProPaymentSummary.Service;
using ProPaymentSummary.Entities;
using ProPaymentSummary.Web.Configuration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace ProPaymentSummary.Web.Areas.Professionals.Api
{
    public class ProfessionalsController : ODataController
    {
        private readonly IProfessionalService _professionalService;

        public ProfessionalsController(IProfessionalService professionalService)
        {
            _professionalService = professionalService;
        }

        public ProfessionalsController()
            : this(new ProfessionalService())
        {
        }

        
        //public async Task<IHttpActionResult> GetLoggedInProfessional()
        //{
        //    var prof = await _professionalService.Get(User.Identity.GetUserId());

        //    return prof;
        //}

        public ProfessionalDto GetLoggedInProfessional()
        {
            
            var prof = _professionalService.Get(User.Identity.GetUserId());

            return prof;
        }
    }
}
