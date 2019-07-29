using Microsoft.EntityFrameworkCore;
using Platzi.Ecom.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void EndTransaction()
        {
            this.dbContext.SaveChanges();
        }

        public void InitTransaction()
        {
            //dbContext.Database.BeginTransaction();
        }
    }
}
