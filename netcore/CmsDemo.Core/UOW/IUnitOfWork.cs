using CmsDemo.Core.Dependency;

namespace CmsDemo.Core.UOW
{
    public interface IUnitOfWork : ITransientDependency
    {
        int SaveChanges();
    }
}
