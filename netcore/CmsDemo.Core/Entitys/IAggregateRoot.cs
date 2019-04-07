namespace CmsDemo.Core.Entities
{
    public interface IAggregateRoot : IAggregateRoot<int>, IEntity
    {

    }

    public interface IAggregateRoot<TPrimaryKey> : IEntity<TPrimaryKey>
    {

    }
}
