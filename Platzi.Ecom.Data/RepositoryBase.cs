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
        protected readonly DbContext dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public virtual void Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Modified;
        }

        public virtual T GetById(int id)
        {
            return dbContext.Set<T>()
                .Where(x => x.Id == id && x.Deleted == false)
                .First();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>()
                .Where(x => x.Deleted == false)
                .ToList();
        }
    }
}
