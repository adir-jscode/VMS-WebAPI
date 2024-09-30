using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class AuditLogsDTO
    {
        
        public int Id { get; set; }
        [Required]
        public string EntityName { get; set; }  // "Volunteer", "User"
        [Required]
        public int EntityId { get; set; }

        public string Action { get; set; }  // "Create", "Update", "Delete"
        public DateTime ActionDate { get; set; }  // When the action occurred
        public string PerformedBy { get; set; }  // Who performed the action
    }
}
