using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Models.Common
{
    public class ResponseBase
    {
        public int? Code { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
