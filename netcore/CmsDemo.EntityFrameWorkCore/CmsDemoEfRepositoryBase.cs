using CmsDemo.EntityFrameWorkCore.Repositories;
using CmsDemo.Models.Entities;

namespace CmsDemo.EntityFrameWorkCore
{
    public class CmsDemoEfRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<CmsDemoDbContext, TEntity, TPrimaryKey>
         where TEntity : class, IEntity<TPrimaryKey>
    {
        public CmsDemoEfRepositoryBase(CmsDemoDbContext dbContext)
            : base(dbContext)
        {
        }
    }

    public class CmsDemoEfRepositoryBase<TEntity> : CmsDemoEfRepositoryBase<TEntity, int>, IRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        public CmsDemoEfRepositoryBase(CmsDemoDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
