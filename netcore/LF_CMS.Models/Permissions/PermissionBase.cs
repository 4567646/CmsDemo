using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Models.Permissions
{
   public class PermissionBase
    {
        /// <summary>
        /// 权限ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 权限代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 按钮描述(在关爱用于按钮图标文件名描述使用)
        /// </summary>
        public string Description { get; set; }
    }
}
