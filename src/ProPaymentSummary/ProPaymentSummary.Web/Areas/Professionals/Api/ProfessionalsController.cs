using System.Web.Http;
using ProPaymentSummary.Entities;
using ProPaymentSummary.Service;
using ProPaymentSummary.Service.Interfaces;
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

        //public Professional LoggedInProfessional()
        //{
        //    return CurrentContext.Professional;
        //}
    }
}
