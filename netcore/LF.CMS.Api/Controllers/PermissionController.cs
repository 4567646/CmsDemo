using AutoMapper;
using LF_CMS.Models.Dto.Permission;
using LF_CMS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LF.CMS.Api
{
    /// <summary>
    /// 权限
    /// </summary>
    [Route("api/[controller]")]
    public class PermissionController : Controller
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        // GET: api/<controller>/{id}
        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(int id)
        {
            var list = _permissionService.GetPermissionAll();
            var result = Mapper.Map<List<PermissionDto>>(list);
            return Ok(result);
        }


    }
}
