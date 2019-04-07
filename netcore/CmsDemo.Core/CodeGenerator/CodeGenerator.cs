using CmsDemo.Core.CodeGenerator.Options;
using CmsDemo.Core.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace CmsDemo.Core.CodeGenerator
{
    /// <summary>
    /// 代码生成器
    /// <remarks>
    /// 根据数据库表以及表对应的列生成对应的数据库实体
    /// </remarks>
    /// </summary>
    public class CodeGenerator
    {
        private readonly string Delimiter = "\\";//分隔符，默认为windows下的\\分隔符
        private readonly CodeGenerateOption _codeGenerateOption;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codeGenerateOption"></param>
        /// <param name="isCoveredExsited">是否覆盖已存在的同名文件</param>
        public CodeGenerator(CodeGenerateOption codeGenerateOption, bool isCoveredExsited = true)
        {
            _codeGenerateOption = codeGenerateOption;
            GenerateTemplateCodesFromDatabase(isCoveredExsited);
        }

        /// <summary>
        /// 
        /// </summary>
        private void GenerateTemplateCodesFromDatabase(bool isCoveredExsited = true)
        {

            var tables = new List<Type>();
            try
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(_codeGenerateOption.EntityLib));
                tables.AddRange(assembly.GetTypes().Where(type => type != null && type.Namespace == _codeGenerateOption.EntityNamespace && !type.IsAbstract));
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            if (tables != null && tables.Any())
            {
                foreach (var table in tables)
                {
                    GenerateIServices(table.Name, isCoveredExsited);
                    GenerateServices(table.Name, isCoveredExsited);

                }
            }
        }

        /// <summary>
        /// 生成IService层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private void GenerateIServices(string tableName, bool ifExsitedCovered = true)
        {
            var iServicesPath = _codeGenerateOption.OutputPath + Delimiter + tableName;
            if (!Directory.Exists(iServicesPath))
            {
                Directory.CreateDirectory(iServicesPath);
            }
            var fullPath = iServicesPath + Delimiter + "I" + tableName + "Service.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("IServicesTemplate.txt");
            content = content.Replace("{Comment}", "代码工具生成")
                .Replace("{Author}", _codeGenerateOption.Author)
                .Replace("{GeneratorTime}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                .Replace("{IServicesNamespace}", _codeGenerateOption.IServicesNamespace)
                .Replace("{ModelName}", tableName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成Services层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private void GenerateServices(string tableName, bool ifExsitedCovered = true)
        {
            var repositoryPath = _codeGenerateOption.OutputPath + Delimiter + tableName;
            if (!Directory.Exists(repositoryPath))
            {
                Directory.CreateDirectory(repositoryPath);
            }
            var fullPath = repositoryPath + Delimiter + tableName + "Service.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("ServiceTemplate.txt");
            content = content.Replace("{Comment}", "代码工具生成")
                .Replace("{Author}", _codeGenerateOption.Author)
                .Replace("{GeneratorTime}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                .Replace("{ServicesNamespace}", _codeGenerateOption.ServicesNamespace)
                .Replace("{ModelName}", tableName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 从代码模板中读取内容
        /// </summary>
        /// <param name="templateName">模板名称，应包括文件扩展名称。比如：template.txt</param>
        /// <returns></returns>
        private string ReadTemplate(string templateName)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var content = string.Empty;
            using (var stream = currentAssembly.GetManifestResourceStream($"{currentAssembly.GetName().Name}.CodeGenerator.CodeTemplate.{templateName}"))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        content = reader.ReadToEnd();
                    }
                }
            }
            return content;
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="fileName">文件完整路径</param>
        /// <param name="content">内容</param>
        private static void WriteAndSave(string fileName, string content)
        {
            //实例化一个文件流--->与写入文件相关联
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                //实例化一个StreamWriter-->与fs相关联
                using (var sw = new StreamWriter(fs))
                {
                    //开始写入
                    sw.Write(content);
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                }
            }
        }

    }
}
