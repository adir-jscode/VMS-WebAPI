using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VMS_API.Controllers
{
    public class AuditLogsController : ApiController
    {
        [HttpGet]
        [Route("api/auditlogs")]
        public HttpResponseMessage AuditLogs()
        {
            try
            {
                var data = AuditLogsService.GetAuditLogs();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
