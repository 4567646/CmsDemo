using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Models.Entities
{
    [Serializable]
    public class EntityNotFoundException : Exception
    {
        /// <summary>
        /// Type of the entity.
        /// </summary>
        public Type EntityType { get; set; }

        /// <summary>
        /// Id of the Entity.
        /// </summary>
        public object Id { get; set; }
        /// <summary>
        /// Creates a new <see cref="EntityNotFoundException"/> object.
        /// </summary>
        public EntityNotFoundException(Type entityType, object id)
        : this(entityType, id, null)
        {

        }
        /// <summary>
        /// Creates a new <see cref="EntityNotFoundException"/> object.
        /// </summary>
        public EntityNotFoundException(Type entityType, object id, Exception innerException)
            : base($"未查询到实体对象. 类型: {entityType.FullName}, id: {id}", innerException)
        {
            EntityType = entityType;
            Id = id;
        }
    }
}
