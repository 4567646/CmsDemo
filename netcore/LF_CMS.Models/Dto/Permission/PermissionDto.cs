using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Models.Dto.Permission
{
    public class PermissionDto
    {
        public String Name { get; set; }

        public Int32? ParentId { get; set; }

        public String IconUrl { get; set; }

        public String LinkUrl { get; set; }

        public Int32? Sort { get; set; }
        /// <summary>
		/// 权限类型：1:模块,2:菜单,3:按钮
		/// </summary>
        public Int32? Type { get; set; }

        public Int32? AddManagerId { get; set; }

        public Int32? UpdateManagerId { get; set; }


    }
}
