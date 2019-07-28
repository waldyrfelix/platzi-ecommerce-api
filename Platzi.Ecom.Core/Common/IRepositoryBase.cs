using System.Collections.Generic;

namespace Platzi.Ecom.Core.Common
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
    }
}