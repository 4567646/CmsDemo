using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LF_CMS.Models.Dto.Admin;
using LF_CMS.Models.Entity;
using LF_CMS.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LF.CMS.Api.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="adminLoginInput"></param>
        /// <response code="200">返回用户信息</response>
        /// <response code="400">参数有误</response>
        // POST api/<controller>
        [HttpPost("Login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<AdminDto> Login([FromBody]AdminLoginInput adminLoginInput)
        {
            var model = _adminService.GetAdminByUserName(adminLoginInput.UserName);
            if (model == null)
            {
                return NotFound("用户名错误");
            }
            else if (model.PassWord != adminLoginInput.Password)
            {
                return BadRequest("密码错误");
            }
            return Ok(Mapper.Map<Admin, AdminDto>(model));
        }


    }
}
