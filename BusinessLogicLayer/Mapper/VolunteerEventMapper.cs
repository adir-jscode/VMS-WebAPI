using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public class VolunteerEventMapper : IMapper<VolunteerEvents, VolunteerEventsDTO>
    {
        public VolunteerEvents Map(VolunteerEventsDTO obj)
        {
            return new VolunteerEvents
            {
                Id = obj.Id,
                VolunteerId = obj.VolunteerId,
                EventId = obj.EventId,
                Status = obj.Status,
                AssignedAt = obj.AssignedAt,
                CompletedAt = obj.CompletedAt
            };
        }

        public VolunteerEventsDTO Map(VolunteerEvents obj)
        {
            return new VolunteerEventsDTO
            {
                Id = obj.Id,
                VolunteerId = obj.VolunteerId,
                EventId = obj.EventId,
                Status = obj.Status,
                AssignedAt = obj.AssignedAt,
                CompletedAt = obj.CompletedAt
            };
        }

        public List<VolunteerEventsDTO> Map(List<VolunteerEvents> obj)
        {
            var volunteerEvents = new List<VolunteerEventsDTO>();
            foreach (var volunteerEvent in obj)
            {
                volunteerEvents.Add(Map(volunteerEvent));
            }
            return volunteerEvents;
        }
    }
}
