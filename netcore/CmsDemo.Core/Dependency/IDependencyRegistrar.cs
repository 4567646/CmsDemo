using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Core.Dependency
{
    /// <summary>
    /// 每次请求都创建一个实例（new）
    /// 默认注入方式
    /// WAR:继承该接口的服务每次请求都会返回一个唯一的实例
    /// </summary>
    public interface IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="config">Config</param>
        void Register(ContainerBuilder builder, List<Type> listType);

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        int Order { get; }
    }
}
