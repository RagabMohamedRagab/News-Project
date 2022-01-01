using Microsoft.AspNetCore.Mvc;
using Project_n9ws.Data;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Controllers
{
    public class NewController : Controller
    {
        readonly INews<Category> _news;

        public NewController(INews<Category> news)
        {
            _news = news;
        }
        [HttpGet]
        // Home/Index
        public IActionResult Index()
        {
            return View(_news.GetAll().Result);
        }
        [HttpGet]
        // Home/About
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        // Home/Services
        public IActionResult Services()
        {
            return View();
        }
       
    }
}
