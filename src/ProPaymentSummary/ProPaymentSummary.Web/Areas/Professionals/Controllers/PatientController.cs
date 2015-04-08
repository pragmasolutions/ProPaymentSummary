using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProPaymentSummary.Service.Data;

namespace ProPaymentSummary.Web.Areas.Professionals.Controllers
{
    public class PatientController : Controller
    {
        // GET: Professionals/Patient
        public ActionResult Index()
        {
            return View();
        }

        // GET: Professionals/Patient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Professionals/Patient/Create
        public ActionResult Create()
        {
            PatientData patientData = new PatientData();
            return View(patientData);
        }

        // GET: Professionals/Patient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: Professionals/Patient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
