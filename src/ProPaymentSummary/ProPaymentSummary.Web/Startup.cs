using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProPaymentSummary.Web.Startup))]
namespace ProPaymentSummary.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
