using AutoMapper;
using LF.CMS.Api.Dto.Permission;
using LF_CMS.Services.Permission;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LF.CMS.Api
{
    [Route("api/[controller]")]
    public class PermissionController : Controller
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _permissionService.GetPermissionAll();
            var result = Mapper.Map<List<PermissionDto>>(list);
            return Ok(result);
        }


    }
}
