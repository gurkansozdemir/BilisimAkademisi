using OBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Data Source = localhost; Initial Catalog = OBSDatabase2; Trusted_Connection=True;")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
