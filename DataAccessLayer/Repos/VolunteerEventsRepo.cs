using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class VolunteerEventsRepo : Repo, IRepo<VolunteerEvents, int, VolunteerEvents>
    {
        public VolunteerEvents Create(VolunteerEvents obj)
        {
            var volunteer = db.Volunteers.Find(obj.VolunteerId);
            var events = db.Events.Find(obj.EventId);
            if (volunteer != null && events != null)
            {
                db.VolenteerEvents.Add(obj);
                if (db.SaveChanges() > 0)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public bool Delete(int id)
        {
            var exist = GetById(id);
            db.VolenteerEvents.Remove(exist);
            return db.SaveChanges() > 0;

        }

        public List<VolunteerEvents> Filter(string keyword)
        {
            var volunteerEvents = db.VolenteerEvents.Where(x => x.Volunteer.Name.Contains(keyword) || x.Event.Name.Contains(keyword)).ToList();
            return volunteerEvents;
        }

        public List<VolunteerEvents> GetAll()
        {
            var data = db.VolenteerEvents.ToList();
            return data;
        }

        public VolunteerEvents GetById(int id)
        {
            var data = db.VolenteerEvents.Find(id);
            return data;
        }

        public VolunteerEvents Search(string name)
        {
            var data = db.VolenteerEvents.Where(x => x.Volunteer.Name == name).FirstOrDefault();
            return data;
        }

        public VolunteerEvents Update(VolunteerEvents obj)
        {
            var exist = GetById(obj.Id);
            db.Entry(exist).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            else
            {
                return null;
            }
        }
    }
}
