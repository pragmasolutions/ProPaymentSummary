using ProPaymentSummary.Service.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace ProPaymentSummary.Web.Controllers
{
    public class OrdersController : ODataController
    {
        // GET: odata/Order
        [HttpGet]
        [EnableQuery]
        public IQueryable<OrderDto> GetOrders()
        {
            return GetOrdersList().AsQueryable();
        }

        private static List<OrderDto> GetOrdersList()
        {
            return new List<OrderDto>() 
            {
                new OrderDto(){
                    OrderNumber = 1,
                    HealthInsuranceProviderName = "SPS Salud",
                    AttentionDate = DateTime.Now,
                    PatientName = "Pepe",
                    PatientDNI = "12551439"
                },
                new OrderDto(){
                    OrderNumber = 2,
                    HealthInsuranceProviderName = "SPS Salud",
                    AttentionDate = DateTime.Now,
                    PatientName = "Juanito",
                    PatientDNI = "43234233"
                },
                new OrderDto(){
                    OrderNumber = 3,
                    HealthInsuranceProviderName = "SPS Salud",
                    AttentionDate = DateTime.Now,
                    PatientName = "Tu Vieja",
                    PatientDNI = "123123123"
                },
                new OrderDto(){
                    OrderNumber = 4,
                    HealthInsuranceProviderName = "SPS Salud",
                    AttentionDate = DateTime.Now,
                    PatientName = "Chicha",
                    PatientDNI = "123123333"
                }
            };
        }

        [EnableQuery]
        public SingleResult<OrderDto> Get([FromODataUri] int key)
        {
            IQueryable<OrderDto> result = GetOrdersList().Where(p => p.Id == key).AsQueryable();
            return SingleResult.Create(result);
        }
    }
}