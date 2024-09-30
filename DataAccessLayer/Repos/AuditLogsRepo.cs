using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class AuditLogsRepo : Repo, IRepo<AuditLogs, int, AuditLogs>
    {
        public AuditLogs Create(AuditLogs obj)
        {
            var audit = db.AuditLogs.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return audit;
            }
            else
            {
                return null;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AuditLogs> Filter(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<AuditLogs> GetAll()
        {
            var data = db.AuditLogs.ToList();
            return data;
        }

        public AuditLogs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public AuditLogs Search(string name)
        {
            throw new NotImplementedException();
        }

        public AuditLogs Update(AuditLogs obj)
        {
            throw new NotImplementedException();
        }
    }
}
