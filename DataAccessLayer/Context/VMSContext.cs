using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class VMSContext : DbContext
    {
        public DbSet<Volunteers> Volunteers { get; set; }
        public DbSet<Events> Events { get; set; }
    }
}
