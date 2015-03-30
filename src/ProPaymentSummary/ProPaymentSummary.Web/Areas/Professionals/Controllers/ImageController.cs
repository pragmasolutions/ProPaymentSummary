using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ProPaymentSummary.Web.Models;
using System.Collections.Generic;
using System.IO;

namespace ProPaymentSummary.Web.Areas.Professionals.Controllers
{
    public class ImageController : Controller
    {
        public ActionResult Save(IEnumerable<HttpPostedFileBase> files)
        {
            // The Name of the Upload component is "files"
            var file = files.FirstOrDefault();
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var tempPath = Server.MapPath("~/Temp");
                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);

                var extension = fileName.Split('.').Last().ToString();
                var finalName = String.Format("{0}.{1}", User.Identity.GetUserId(), extension);
                var physicalPath = Path.Combine(tempPath, finalName);

                file.SaveAs(physicalPath);
            
                return Content("");
            }
            return Content("No se ha seleccionado ningún archivo");
        }

    }
}