using System;

namespace Platzi.Ecom.Core.Common
{
    public interface IUnitOfWork : IDisposable
    {
        void InitTransaction();

        void EndTransaction();
    }
}
