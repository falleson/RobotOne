using RobotOne.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RobotOne.DAL
{
    public class GeneralRepository<T> : IRepository<T>
            where T : EntityBase
    {
        private readonly DbContext context;
        private readonly DbSet<T> dbset;
        public GeneralRepository(DbContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }
        public T GetById(int id)
        {
            return dbset.First(s => s.Id == id);
        }

        public T Get(Expression<Func<T, bool>> predict)
        {
            return dbset.SingleOrDefault(predict);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset;
        }

        public IEnumerable<T> GetMany(Expression<Func<T,bool>> predict)
        {
            return dbset.Where(predict);
        }

        public void AddOrUpdate(T entity)
        {
            dbset.AddOrUpdate(entity);
        }

        public T Delete(T entity)
        {
           return dbset.Remove(entity);
        }
    }
}
