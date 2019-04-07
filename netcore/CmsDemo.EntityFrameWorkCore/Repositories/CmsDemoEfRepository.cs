using CmsDemo.Core.Entities;
using CmsDemo.Core.Repositories;
using CmsDemo.Core.UOW;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CmsDemo.EntityFrameWorkCore.Repositories
{
    public class CmsDemoEfRepository<TEntity> : CmsDemoEfRepository<TEntity, int>, IRepository<TEntity>
         where TEntity : class, IEntity, IAggregateRoot
    {
        public CmsDemoEfRepository(CmsDemoDbContext dbContext)
            : base(dbContext)
        {
        }
    }

    public class CmsDemoEfRepository<TEntity, TPrimaryKey> : Repository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>, IAggregateRoot<TPrimaryKey>
    {
        private readonly CmsDemoDbContext _dbContext;

        public virtual DbSet<TEntity> Table => _dbContext.Set<TEntity>();

        public CmsDemoEfRepository(CmsDemoDbContext dbDbContext)
        {
            _dbContext = dbDbContext;
        }

        public override IQueryable<TEntity> GetAll()
        {
            return Table.AsQueryable();
        }

        public override TEntity Insert(TEntity entity)
        {
            var newEntity = Table.Add(entity).Entity;
            return newEntity;
        }

        public override TEntity Update(TEntity entity)
        {
            AttachIfNot(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public override void Delete(TEntity entity)
        {
            AttachIfNot(entity);
            Table.Remove(entity);
        }

        public override void Delete(TPrimaryKey id)
        {
            var entity = GetFromChangeTrackerOrNull(id);
            if (entity != null)
            {
                Delete(entity);
                return;
            }

            entity = FirstOrDefault(id);
            if (entity != null)
            {
                Delete(entity);
                return;
            }
        }

        public DbContext GetDbContext()
        {
            return _dbContext;
        }

        protected virtual void AttachIfNot(TEntity entity)
        {
            var entry = _dbContext.ChangeTracker.Entries().FirstOrDefault(ent => ent.Entity == entity);
            if (entry != null)
            {
                return;
            }

            Table.Attach(entity);
        }

        private TEntity GetFromChangeTrackerOrNull(TPrimaryKey id)
        {
            var entry = _dbContext.ChangeTracker.Entries()
                .FirstOrDefault(
                    ent =>
                        ent.Entity is TEntity &&
                        EqualityComparer<TPrimaryKey>.Default.Equals(id, ((TEntity)ent.Entity).Id)
                );

            return entry?.Entity as TEntity;
        }
    }
}