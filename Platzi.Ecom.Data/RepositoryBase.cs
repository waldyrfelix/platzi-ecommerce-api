using Microsoft.EntityFrameworkCore;
using Platzi.Ecom.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Platzi.Ecom.Data
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class, IEntity
    {
        private readonly DbContext dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Modified;
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>()
                .Where(x => x.Id == id && x.Deleted == false)
                .First();
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>()
                .Where(x => x.Deleted == false)
                .ToList();
        }
    }
}
