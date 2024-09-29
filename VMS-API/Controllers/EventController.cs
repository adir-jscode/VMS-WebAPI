using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VMS_API.Controllers
{
    public class EventController : ApiController
    {
        [HttpGet]
        [Route("api/event")]
        public HttpResponseMessage Events()
        {
            try
            {
                var data = EventService.GetAllEvents();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpDelete]
        [Route("api/event/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = EventService.DeleteEvent(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/event")]
        public HttpResponseMessage CreateEvent(EventDTO eventDTO)
        {
            try
            {
                var data = EventService.CreateEvent(eventDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("api/event")]
        public HttpResponseMessage UpdateEvent(EventDTO eventDTO)
        {
            try
            {
                var data = EventService.UpdateEvent(eventDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
