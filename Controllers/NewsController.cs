using Microsoft.AspNetCore.Mvc;
using Project_n9ws.Data;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Controllers
{
    public class NewsController : Controller
    {
        readonly INew<Category> _news; 
        readonly INew<ContactUs> _contact;
        readonly INewsByID<New> _newsByID;
        public NewsController(INew<Category> news, INew<ContactUs> contact, INewsByID<New> newsByID)
        {
            _news = news;
            _contact = contact;
            _newsByID = newsByID;
        }

        [HttpGet] // News/Index
        public IActionResult Index()
        {
            return View(_news.GetAll().Result);
        }
        [HttpGet] // News/About
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Services()
        {
            return View();
        }
        [HttpGet] // Get : News/ContactMess
        public IActionResult ContactMess()
        {
            return View(_contact.GetAll().Result);
        }
        [HttpGet] // Get : News/Contactus
        public IActionResult Contactus()
        {
            return View();
        }
        [HttpPost] // Post : News/Contactus 
        [ValidateAntiForgeryToken]
        public IActionResult Contactus([FromForm] ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                _contact.Create(contactUs);
                ModelState.Clear();
                return RedirectToAction(nameof(Index));
            }

            return View(contactUs);
        }
        [HttpGet] // News/New/Id
        public IActionResult New([FromQuery]int Id)
        {
            if (Id == 0)
            {
                return View("Error");
            }
            ViewBag.TypeNews = _news.Get(Id).Result.Name;
            return View(_newsByID.GetAll(Id).Result);
        }
        [HttpGet] // News/Register
        public IActionResult Register()
        {
            return View();
        }

    }
}
