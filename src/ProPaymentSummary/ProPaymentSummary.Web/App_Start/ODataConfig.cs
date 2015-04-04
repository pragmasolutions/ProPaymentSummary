using ProPaymentSummary.Service.Dto;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using ProPaymentSummary.Entities;
using ProPaymentSummary.Service.Data;

namespace ProPaymentSummary.Web
{
    public static class ODataConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EnableLowerCamelCase();

            builder.EntitySet<OrderDto>("orders");
            builder.EntitySet<OrderDto>("appointments");
            builder.EntitySet<PatientData>("patients");

            config.MapODataServiceRoute("ODataRoute", "odata", builder.GetEdmModel());
        }
    }
}