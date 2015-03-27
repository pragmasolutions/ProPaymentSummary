using System.Web.Mvc;

namespace ProPaymentSummary.Web.Areas.Professionals
{
    public class ProfessionalsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Professionals";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Professionals_default",
                "Professionals/{controller}/{action}/{id}",
                new { action = "Index",controller = "Home", id = UrlParameter.Optional },
                new[] { "ProPaymentSummary.Web.Areas.Professionals.Controllers" } 
            );
        }
    }
}