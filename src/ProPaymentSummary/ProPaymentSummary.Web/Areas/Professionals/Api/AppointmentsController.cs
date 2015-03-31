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

namespace ProPaymentSummary.Web.Areas.Professionals.Api
{
    public class AppointmentsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Appointments
        public async Task<IHttpActionResult> GetAppointments(ODataQueryOptions<AppointmentDto> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<AppointmentDto>>(AppointmentDtoes);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/Appointments(5)
        public async Task<IHttpActionResult> GetAppointment([FromODataUri] int key, ODataQueryOptions<AppointmentDto> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<AppointmentDto>(AppointmentDto);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Appointments(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<AppointmentDto> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(AppointmentDto);

            // TODO: Save the patched entity.

            // return Updated(AppointmentDto);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Appointments
        public async Task<IHttpActionResult> Post(AppointmentData appointmentData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(AppointmentDto);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Appointments(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<AppointmentDto> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(AppointmentDto);

            // TODO: Save the patched entity.

            // return Updated(AppointmentDto);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Appointments(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
