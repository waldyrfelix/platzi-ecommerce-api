using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Core.Common
{
    public interface IEntity
    {
        int Id { get; set; }

        bool Deleted { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }
    }
}
