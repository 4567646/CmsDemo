using Autofac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Core.UOW
{
    public class UnitOfWork<TDbContext> : IUnitOfWork where TDbContext : DbContext
    {
        private readonly TDbContext _dbContext;

        public UnitOfWork(TDbContext context)
        {
            _dbContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
