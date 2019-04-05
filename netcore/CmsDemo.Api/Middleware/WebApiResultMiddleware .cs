using CmsDemo.Core.Util;
using CmsDemo.Models.Common;
using CmsDemo.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsDemo.Api.Middleware
{
    public class WebApiResultMiddleware : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            //根据实际需求进行具体实现
            if (context.Result is ObjectResult)
            {
                var objectResult = context.Result as ObjectResult;
                context.Result = new ObjectResult(new ResponseBase()
                {
                    Code = objectResult.StatusCode,
                    Message = PublicFunction.GetDescription((StatusCodeEnum)objectResult.StatusCode),
                    Result = objectResult.Value
                })
                { StatusCode = objectResult.StatusCode };
            }
            else if (context.Result is EmptyResult)
            {
                context.Result = new ObjectResult(new ResponseBase() { Code = (int)StatusCodeEnum.HttpNoFoundError, Message = PublicFunction.GetDescription(StatusCodeEnum.HttpNoFoundError) });
            }
            else if (context.Result is ContentResult)
            {
                context.Result = new ObjectResult(new ResponseBase() { Code = (int)StatusCodeEnum.Success, Message = PublicFunction.GetDescription(StatusCodeEnum.Success), Result = (context.Result as ContentResult).Content });
            }
            else if (context.Result is StatusCodeResult)
            {
                context.Result = new ObjectResult(new { code = (context.Result as StatusCodeResult).StatusCode, sub_msg = "", msg = "" });
            }
        }
    }
}