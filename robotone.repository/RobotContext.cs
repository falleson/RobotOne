using RobotOne.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOne.DAL
{
    public class RobotContext: DbContext
    {
        public RobotContext() 
            :base("name=RobotContext")
        {

        }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Log> Logs { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Bot> Bots { get; set; }
    }
}
