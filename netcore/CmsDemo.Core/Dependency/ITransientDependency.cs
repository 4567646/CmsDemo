namespace CmsDemo.Core.Dependency
{
    /// <summary>
    ///单一实例
    ///WAR:与单例的区别
    ///  单例：在整个应用程序周期内只有唯一的实例
    ///  作用域内唯一：在一个请求期间的生命周期内只有唯一的实例
    /// </summary>
    /// <remarks>
    ///每个作用域内只有唯一的实例
    /// </remarks>
    public interface ITransientDependency
    {
    }
}
