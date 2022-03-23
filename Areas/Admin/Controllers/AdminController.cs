using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Dasboard()
        {
            return View();
        }
    }
}
