using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Core.Common
{
    public interface IEntity
    {
        int Id { get; }

        bool Deleted { get; }
    }
}
