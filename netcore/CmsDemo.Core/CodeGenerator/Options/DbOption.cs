using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Core.Options
{
    /// <summary>
    /// 数据库连接选项
    /// </summary>
    public class DbOption
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DbType { get; set; }
    }
}