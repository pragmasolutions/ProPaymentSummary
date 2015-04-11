using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ProPaymentSummary.Service;
using ProPaymentSummary.Service.Dto;
using ProPaymentSummary.Service.Interfaces;

namespace ProPaymentSummary.Web.Areas.Professionals.Controllers
{
    public class ProfessionalController : Controller
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


        // GET: Professionals/Professional
        public ActionResult Profile()
        {
            var prof = _professionalService.Get(User.Identity.GetUserId());
            //var prof = new ProfessionalDto();
            return View(prof);
        }
    }
}