using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class VolunteersRepo : Repo, IRepo<Volunteers, int, Volunteers>
    {
        public Volunteers Create(Volunteers obj)
        {
            db.Volunteers.Add(obj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }
            else
            {
                return null;
            }
        }

        public bool Delete(int id)
        {
            var exist = GetById(id);
            db.Volunteers.Remove(exist);
            return db.SaveChanges() > 0;
        }

        public List<Volunteers> Filter(string keyword)
        {
            //filter can be done by name, email, phone number
            var volunteers = db.Volunteers.Where(x => x.Name.Contains(keyword) || x.Availability.Contains(keyword) || x.Phone.Contains(keyword)).ToList();
            return volunteers;
        }

        public List<Volunteers> GetAll()
        {
           var volunteers = db.Volunteers.ToList();
           return volunteers;
        }

        public Volunteers GetById(int id)
        {
            var volunteer = db.Volunteers.Find(id);
            if (volunteer != null)
            {
                return volunteer;
            }
            else
            {
                return null;
            }

        }

        public Volunteers Search(string name)
        {
            var volunteer = db.Volunteers.Where(x => x.Name == name).FirstOrDefault();
            if (volunteer != null)
            {
                return volunteer;
            }
            else
            {
                return null;
            }
        }

        public Volunteers Update(Volunteers obj)
        {
            var exist = GetById(obj.Id);
            db.Entry(exist).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0)
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
