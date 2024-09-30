using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VMS_API.Controllers
{
    public class EventVolunteerController : ApiController
    {
        [HttpPost]
        [Route("api/eventvolunteer/assign")]


        public HttpResponseMessage Assign(int volunteerId, int eventId)
        {
            try
            {
                VolunteerEventService.AssignVolunteerToEvent(volunteerId, eventId);
                //audit log
                AuditLogsService.LogAction("VolunteerEvent", eventId, "Volunteer assigned to event", "User");
                return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Volunteer assigned to event" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }   
        }
    }
