using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class VolunteerEvents
    {
        [Key]
        public int Id { get; set; }

        // Foreign keys and navigation properties
        [ForeignKey("Volunteer")]
        public int VolunteerId { get; set; }
        public Volunteers Volunteer { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Events Event { get; set; }
        public int? Status { get; set; }  // "Assigned", "Participated", "Ongoing"
        public DateTime AssignedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
