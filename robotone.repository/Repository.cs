using RobotOne.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOne.DAL
{
    public class Repository :IUniteOfWork, IDisposable
    {
        private readonly DbContext context;
        private GeneralRepository<Log> logRepository;
        private GeneralRepository<Group> groupRepository;
        private GeneralRepository<Bot> botRepository;
        private GeneralRepository<User> userRepository;
        public Repository()
            :this(new RobotContext())
        {

        }
        public Repository(DbContext context)
        {
            this.context = context;
        }

        public GeneralRepository<Log> LogRepository => logRepository ?? (logRepository = new GeneralRepository<Log>(context));
        public GeneralRepository<Group> GroupRepository => groupRepository ?? (groupRepository = new GeneralRepository<Group>(context));
        public GeneralRepository<Bot> BotRepository => botRepository ?? (botRepository = new GeneralRepository<Bot>(context));

        public GeneralRepository<User> UserRepository => userRepository ?? (userRepository = new GeneralRepository<User>(context));

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            if (context != null)
            {
                this.context.Dispose();
            }
        }

       
    }
}
