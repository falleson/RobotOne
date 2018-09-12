using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RobotOne.DAL
{
    public interface IRepository<T>
    {
        T GetById(int id);

        T Get(Expression<Func<T, bool>> where);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        void AddOrUpdate(T entity);

        T Delete(T entity);
    }
}
