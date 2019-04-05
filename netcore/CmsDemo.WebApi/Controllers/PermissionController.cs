using AutoMapper;
using CmsDemo.Core.Redis;
using CmsDemo.Models.Dto.Permission;
using CmsDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CmsDemo.WebApi
{
    /// <summary>
    /// 权限
    /// </summary>
    [Route("api/[controller]")]
    public class PermissionController : Controller
    {
        private readonly IDistributedCache _cache;
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService, IDistributedCache cache)
        {
            _permissionService = permissionService;
            _cache = cache;
        }
        // GET: api/<controller>/{id}
        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <response code="200">返回用户信息</response>
        /// <response code="400">参数有误</response>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Get(int id)
        {
            string CacheKey = $"GetPermissionById__{id}";

            string CacheValue = _cache.GetString(CacheKey);
            if (string.IsNullOrWhiteSpace(CacheValue))
            {
                CacheValue = JsonConvert.SerializeObject(_permissionService.GetPermissionAll());
                _cache.SetString(CacheKey, CacheValue);
            }
            var list = JsonConvert.DeserializeObject<List<CmsDemo.Models.Entity.Permission>>(CacheValue);
            var result = Mapper.Map<List<PermissionDto>>(list);
            return Ok(result);
        }


    }
}
