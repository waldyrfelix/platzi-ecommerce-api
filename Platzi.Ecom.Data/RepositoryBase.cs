using Platzi.Ecom.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Platzi.Ecom.Data
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class, IEntity
    {
        private static List<T> list = new List<T>();

        public void Insert(T entity)
        {
            list.Add(entity);
        }

        public void Update(T entity)
        {

        }

        public T GetById(int id)
        {
            return list.Where(x => x.Id == id && x.Deleted == false).First();
        }

        public IEnumerable<T> GetAll()
        {
            return list.Where(x => x.Deleted == false).ToList();
        }
    }
}
