
using CmsDemo.Core.Dependency;

namespace CmsDemo.Services.Admin
{
    public interface IAdminService : ITransientDependency
    {
        /// <summary>
        /// ����id��ȡʵ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Core.Entities.Admin GetEntityById(int id);
        /// <summary>
        /// ����idɾ��ʵ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(int id);
        /// <summary>
        ///����ʵ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Core.Entities.Admin Insert(Core.Entities.Admin admin);
        /// <summary>
        ///����ʵ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Core.Entities.Admin Update(Core.Entities.Admin admin);
        Core.Entities.Admin GetAdminByUserName(string userName);
    }
}