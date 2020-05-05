using Onion.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T Get(int id);
        IQueryable<T> GetQueryable(long id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
