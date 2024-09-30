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
    public class VolunteerController : ApiController
    {
        [HttpGet]
        [Route("api/volunteer")]
        public HttpResponseMessage Volunteers()
        {
            try
            {
                var data = VolunteerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message});
            }
        }

        [HttpDelete]
        [Route("api/volunteer/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = VolunteerService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        
        [HttpPost]
        [Route("api/volunteer")]
        public HttpResponseMessage Create(VoluenteerDTO volunteer)
        {
            try
            {
                var data = VolunteerService.Create(volunteer);
                AuditLogsService.LogAction("Volunteer", data.Id, "Volunteer created", "User");
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/volunteer/search/{name}")]
        public HttpResponseMessage Search(string name)
        {
            try
            {
                var data = VolunteerService.Search(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        
        [HttpGet]
        [Route("api/volunteer/filter/{keyword}")]
        public HttpResponseMessage Filter(string keyword)
        {
            try
            {
                var data = VolunteerService.Filter(keyword);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("api/volunteer")]
        public HttpResponseMessage Update(VoluenteerDTO volunteer)
        {
            try
            {
                var data = VolunteerService.Update(volunteer);
                AuditLogsService.LogAction("Volunteer", data.Id, "Volunteer updated", "User");
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}
