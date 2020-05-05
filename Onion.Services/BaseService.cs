using Onion.Entities.Base;
using Onion.Interfaces.Repositories;
using Onion.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public int Delete(T entity)
        {
            return _baseRepository.Delete(entity);
        }

        public int Delete(int id)
        {
            T Entity = Get(id);
            if (Entity != null)
                return Delete(Entity);
            return 0;
        }

        public T Get(int id)
        {
            return _baseRepository.Get(id);
        }

        public IQueryable<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public IQueryable<T> GetQueryable(long id)
        {
            return _baseRepository.GetQueryable(id);
        }

        public int Insert(T entity)
        {
            return _baseRepository.Insert(entity);
        }

        public int Update(T entity)
        {
            return _baseRepository.Update(entity);
        }
    }
}
