using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Mapper;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class AuditLogsService
    {
        public static AuditLogsMapper AuditLogsMapper = new AuditLogsMapper();

        public static void LogAction(string entityName, int entityId, string action, string performedBy)
        {
            var auditLog = new AuditLogsDTO
            {
                EntityName = entityName,
                EntityId = entityId,
                Action = action,
                ActionDate = DateTime.Now,
                PerformedBy = performedBy
            };
            DataAccessFactory.AuditLogsData().Create(AuditLogsMapper.Map(auditLog));
        }

        public static List<AuditLogsDTO> GetAuditLogs()
        {
            return AuditLogsMapper.Map(DataAccessFactory.AuditLogsData().GetAll());
        }
    }
}
