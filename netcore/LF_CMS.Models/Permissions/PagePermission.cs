using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Models.Permissions
{
    /// <summary>
    /// 页面权限
    /// </summary>
    public class PagePermission
    {
        /// <summary>
        /// 拥有的按钮权限集,K：Code，V：ButtonPer
        /// </summary>
        public Dictionary<int, ButtonPermission> ButtonPers = new Dictionary<int, ButtonPermission>();

        /// <summary>
        /// 拥有的数据集权限集,K：Code，V：DataSetPer
        /// 暂未设计
        /// </summary>
        //public Dictionary<int, DataSetPermission> DataSetsPers = new Dictionary<int, DataSetPermission>();
        
    }
}
