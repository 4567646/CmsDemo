using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Models.Permissions
{
    /// <summary>
    /// 模块权限
    /// </summary>
    public class ModulePermission : PermissionBase
    {
        /// <summary>
        /// 拥有的页面权限集,K：Code，V：PagePer
        /// </summary>
        public Dictionary<int, PagePermission> PagePers = new Dictionary<int, PagePermission>();
    }
}
