using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public class EventMapper : IMapper<Events, EventDTO>
    {
        public Events Map(EventDTO obj)
        {
            return new Events
            {
                Id = obj.Id,
                Name = obj.Name,
                Description = obj.Description,
                StartDateTime = obj.StartDateTime,
                Location = obj.Location,
                EndDateTime = obj.EndDateTime,
                CreatedAt = obj.CreatedAt,
                UpdatedAt = obj.UpdatedAt
            };
        }

        public EventDTO Map(Events obj)
        {
            return new EventDTO
            {
                Id = obj.Id,
                Name = obj.Name,
                Description = obj.Description,
                StartDateTime = obj.StartDateTime,
                Location = obj.Location,
                EndDateTime = obj.EndDateTime,
                CreatedAt = obj.CreatedAt,
                UpdatedAt = obj.UpdatedAt
            };
        }

        public List<EventDTO> Map(List<Events> obj)
        {
            var events = new List<EventDTO>();
            foreach (var e in obj)
            {
                events.Add(Map(e));
            }
            return events;
        }
    }
}
