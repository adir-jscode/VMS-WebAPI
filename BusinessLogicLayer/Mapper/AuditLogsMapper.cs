using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public class AuditLogsMapper : IMapper<AuditLogs, AuditLogsDTO>
    {
        public AuditLogs Map(AuditLogsDTO obj)
        {
            return new AuditLogs
            {
                Id = obj.Id,
                EntityName = obj.EntityName,
                EntityId = obj.EntityId,
                Action = obj.Action,
                ActionDate = obj.ActionDate,
                PerformedBy = obj.PerformedBy
            };
        }

        public AuditLogsDTO Map(AuditLogs obj)
        {
            return new AuditLogsDTO
            {
                Id = obj.Id,
                EntityName = obj.EntityName,
                EntityId = obj.EntityId,
                Action = obj.Action,
                ActionDate = obj.ActionDate,
                PerformedBy = obj.PerformedBy
            };
        }

        public List<AuditLogsDTO> Map(List<AuditLogs> obj)
        {
            var auditLogs = new List<AuditLogsDTO>();
            foreach (var auditLog in obj)
            {
                auditLogs.Add(Map(auditLog));
            }
            return auditLogs;
        }
    }
}
