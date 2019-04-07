
using CmsDemo.Core.Dependency;

namespace CmsDemo.Services.Admin
{
    public interface IAdminService : ITransientDependency
    {
        /// <summary>
        /// 根据id获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Core.Entities.Admin GetEntityById(int id);
        /// <summary>
        /// 根据id删除实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(int id);
        /// <summary>
        ///插入实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Core.Entities.Admin Insert(Core.Entities.Admin admin);
        /// <summary>
        ///更新实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Core.Entities.Admin Update(Core.Entities.Admin admin);
        Core.Entities.Admin GetAdminByUserName(string userName);
    }
}