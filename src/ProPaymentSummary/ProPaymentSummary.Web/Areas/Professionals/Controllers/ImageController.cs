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
using System.Drawing;

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
                var finalName = String.Format("{0}.png", User.Identity.GetUserId());
                var physicalPath = Path.Combine(tempPath, finalName);

                file.SaveAs(physicalPath);
            
                return Content("");
            }
            return Content("No se ha seleccionado ningún archivo");
        }

        public ActionResult SaveUserImage(int x, int y, int w, int h) 
        {
            var rectangle = new Rectangle()
            {
                X = x,
                Y = y,
                Width = w,
                Height = h
            };

            var tempPath = Server.MapPath("~/Temp");
            var finalName = String.Format("{0}.png", User.Identity.GetUserId());
            var physicalPath = Path.Combine(tempPath, finalName);
            var image = Image.FromFile(physicalPath);
            var croppedImage = CropImage(image, rectangle);
            return null;
        }

        private static Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

    }
}