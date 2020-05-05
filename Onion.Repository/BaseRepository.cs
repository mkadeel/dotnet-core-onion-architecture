using Microsoft.EntityFrameworkCore;
using Onion.Entities.Base;
using Onion.Infrastructure;
using Onion.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly ApplicationContext _context;
        private DbSet<T> entities;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public int Delete(T entity)
        {
            entities.Remove(entity);
            return SaveChanges();
        }

        public T Get(int id)
        {
            return entities.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public IQueryable<T> GetQueryable(long id)
        {
            return entities.Where(x => x.Id == id).AsQueryable();
        }

        public int Insert(T entity)
        {
            entities.Add(entity);
            return SaveChanges();
        }

        public int Update(T entity)
        {
            entities.Update(entity);
            return SaveChanges();
        }

        public IQueryable<T> Where(Func<T, bool> where)
        {
            return entities.Where(where).AsQueryable();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
