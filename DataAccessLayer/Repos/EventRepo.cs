using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class EventRepo : Repo,IRepo<Events, int, Events>
    {
        public Events Create(Events obj)
        {
            db.Events.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var obj = GetById(id);
            db.Events.Remove(obj);
            db.SaveChanges();
            return true;
        }

        public List<Events> Filter(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<Events> GetAll()
        {
            return db.Events.ToList();
        }

        public Events GetById(int id)
        {
            return db.Events.Find(id);
        }

        public Events Search(string name)
        {
            throw new NotImplementedException();
        }

        public Events Update(Events obj)
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
