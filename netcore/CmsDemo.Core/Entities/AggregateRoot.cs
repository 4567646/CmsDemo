namespace CmsDemo.Core.Entities
{
    public abstract class AggregateRoot : AggregateRoot<int>, IAggregateRoot
    {

    }
    public abstract class AggregateRoot<TPrimaryKey> : Entity<TPrimaryKey>, IAggregateRoot<TPrimaryKey>
    {

    }
}
