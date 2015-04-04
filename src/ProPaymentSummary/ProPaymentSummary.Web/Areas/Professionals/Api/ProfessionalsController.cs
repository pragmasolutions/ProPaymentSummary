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
using ProPaymentSummary.Entities;
using ProPaymentSummary.Web.Configuration;

namespace ProPaymentSummary.Web.Areas.Professionals.Api
{
    public class ProfessionalsController : ApiController
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

        public Professional LoggedInProfessional()
        {
            return CurrentContext.Professional;
        }
    }
}
