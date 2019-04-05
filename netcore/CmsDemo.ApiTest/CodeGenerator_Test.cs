using CmsDemo.Core.CodeGenerator;
using CmsDemo.Test.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CmsDemo.ApiTest
{
    public class CodeGenerator_Test : TestBase
    {
        [Fact]
        public void CodeGenerator()
        {
            var service = _serviceProvider.GetService<CodeGenerator>();
            service.GenerateTemplateCodesFromDatabase();

        }
    }
}
