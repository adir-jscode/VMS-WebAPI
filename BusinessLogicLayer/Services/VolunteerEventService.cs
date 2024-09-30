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
    public class VolunteerEventService
    {
        public static VolunteerEventMapper VolunteerEventMapper = new VolunteerEventMapper();
        public static void AssignVolunteerToEvent(int volunteerId, int eventId)
        {
            var volunteerEvent = new VolunteerEventsDTO
            {
                VolunteerId = volunteerId,
                EventId = eventId,
                Status = 1,
                AssignedAt = DateTime.Now
            };
           DataAccessFactory.VolunteerEventsData().Create(VolunteerEventMapper.Map(volunteerEvent));

        }
    }
}
