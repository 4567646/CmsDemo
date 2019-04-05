using CmsDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.EntityFrameWorkCore.Repositories
{
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {

    }
}
