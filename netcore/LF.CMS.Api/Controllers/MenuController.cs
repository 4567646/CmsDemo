using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LF_CMS.Models.Entity;
using LF_CMS.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LF.CMS.Api.Controllers
{
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<IEnumerable<Menu>> Get()
        {
            return await _menuService.GetAllAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
