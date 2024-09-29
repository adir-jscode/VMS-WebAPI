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
    public class EventService
    {
        public static EventMapper EventMapper = new EventMapper();
        public static List<EventDTO> GetAllEvents()
        {
            var data = DataAccessFactory.EventsData().GetAll();
            var allEvents = EventMapper.Map(data);
            return allEvents;

        }

        public static EventDTO GetEvent(int id)
        {
            var data = DataAccessFactory.EventsData().GetById(id);
            var eventDTO = EventMapper.Map(data);
            return eventDTO;
        }

        public static EventDTO CreateEvent(EventDTO eventDTO)
        {
            var data = EventMapper.Map(eventDTO);
            var createdEvent = DataAccessFactory.EventsData().Create(data);
            return EventMapper.Map(createdEvent);
        }

        public static EventDTO UpdateEvent(EventDTO eventDTO)
        {
            var data = EventMapper.Map(eventDTO);
            var updatedEvent = DataAccessFactory.EventsData().Update(data);
            return EventMapper.Map(updatedEvent);
        }

        public static bool DeleteEvent(int id)
        {
            return DataAccessFactory.EventsData().Delete(id);
        }
    }
}
