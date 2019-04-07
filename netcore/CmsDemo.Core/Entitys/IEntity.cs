using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Core.Entities
{
    public interface IEntity : IEntity<int>
    {

    }
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}
