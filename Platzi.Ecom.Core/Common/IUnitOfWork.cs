using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Core.Common
{
    public interface IUnitOfWork
    {
        void InitTransaction();

        void EndTransaction();
    }
}
