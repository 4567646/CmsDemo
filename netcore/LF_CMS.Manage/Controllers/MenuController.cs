using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LF_CMS.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LF_CMS.Manage.Controllers
{
    public class MenuController : Controller
    {
       
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
