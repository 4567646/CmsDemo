using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Core.Options
{
    /// <summary>
    /// 代码生成选项
    /// </summary>
    public class CodeGenerateOption 
    {

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 代码生成时间
        /// </summary>
        public string GeneratorTime { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 输出路径
        /// </summary>
        public string OutputPath { get; set; }
        /// <summary>
        /// 实体所在程序集
        /// </summary>
        public string EntityLib { get; set; }
        /// 实体命名空间
        /// </summary>
        public string EntityNamespace { get; set; }
        /// 服务接口命名空间
        /// </summary>
        public string IServicesNamespace { get; set; }
        /// <summary>
        /// 服务命名空间
        /// </summary>
        public string ServicesNamespace { get; set; }
    }
}
