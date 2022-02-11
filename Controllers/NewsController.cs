﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_n9ws.Data;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Controllers
{
    public class NewsController : Controller
    {
        readonly INew<Category> _news; 
        readonly INew<ContactUs> _contact;
        readonly INewsByID<New> _newsByID;
        readonly INew<User> _User;
        readonly IWebHostEnvironment _webHost;
        readonly INew<Country> _Country;
        public NewsController(INew<Category> news, INew<ContactUs> contact, INewsByID<New> newsByID, INew<User> user, IWebHostEnvironment webHost, INew<Country> country)
        {
            _news = news;
            _contact = contact;
            _newsByID = newsByID;
            _User = user;
            _webHost = webHost;
            _Country = country;
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
            ViewBag.Countries = new SelectList(_Country.GetAll().Result.Select(b => b.Name).Distinct());
            return View();
        }
        [HttpPost] // News/Index
        public IActionResult Register(User user)
        {
            string FileName = string.Empty;
            if (user.File != null)
            {
                string DirectFolder = Path.Combine(_webHost.WebRootPath, @"assets\img");
                 FileName = user.File.FileName;
                string FullDirecteFolder = Path.Combine(DirectFolder, FileName);
                FileStream  stream = new FileStream(FullDirecteFolder, FileMode.Create);
                user.File.CopyTo(stream);
            }
            user.Image = FileName;
            if (ModelState.IsValid)
            {
                if (_User.Create(user).Result > 0)
                    return RedirectToAction(nameof(Index));
                
            }
            return View();
        }
    }
}
