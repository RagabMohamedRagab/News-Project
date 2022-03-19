using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Project_n9ws.Data;
using Project_n9ws.Models;
using Project_n9ws.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Project_n9ws.ViewModel;

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
        readonly SearchEmail _searchEmail;
        readonly INew<Comment> _comment;
        readonly INew<Team> _Team;

        public NewsController(INew<Category> news, INew<ContactUs> contact, INewsByID<New> newsByID, INew<User> user, IWebHostEnvironment webHost, INew<Country> country, SearchEmail searchEmail, INewsByID<New> newsByID1, INew<Comment> comment, INew<Team> team)
        {
            _news = news;
            _contact = contact;
            _newsByID = newsByID;
            _User = user;
            _webHost = webHost;
            _Country = country;
            _searchEmail = searchEmail;
            _comment = comment;
            _Team = team;
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
        public IActionResult TeamMember()
        {

            return View(_Team.GetAll().Result);
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
        public IActionResult New([FromRoute] int Id)
        {
            if (Id == 0)
            {
                return View("Error");
            }
            HttpContext.Session.SetString("Route-ID", Id.ToString());
            ViewBag.DisplayComment = _comment.GetAll().Result;

            ViewBag.TypeNews = _news.Get(Id).Result.Name;

            return View(_newsByID.GetAll(Id).Result);
        }
        // Start Register Form Action
        [HttpGet] // News/Register
        public IActionResult Register()
        {
            ViewBag.Countries = new SelectList(_Country.GetAll().Result.Select(b => b.Name).Distinct());
            return View();
        }
        [HttpPost] // News/Index
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            string FileName = string.Empty;
            if (user.File != null)
            {
                string DirectFolder = Path.Combine(_webHost.WebRootPath, @"assets\img");
                FileName = user.File.FileName;
                string FullDirecteFolder = Path.Combine(DirectFolder, FileName);
                FileStream stream = new FileStream(FullDirecteFolder, FileMode.Create);
                user.File.CopyTo(stream);
            }
            var NewID = _Country.GetAll().Result.Where(P => P.Name == Request.Form["country"]).FirstOrDefault();
            if (NewID != null)
            {
                user.CountryId = NewID.ID;
            }
            user.Image = FileName;
            if (ModelState.IsValid)
            {
                if (_User.Create(user).Result > 0)
                HttpContext.Session.SetString("UserID", (user.ID).ToString());
                HttpContext.Session.SetString("UserName", user.FirstName);
                HttpContext.Session.SetString("Image", user.Image);
                return RedirectToAction(nameof(Index));

            }

            return View();
        }
        // End Register Form Action
        // Start Login Form Action
        [HttpGet] // News/Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]  // News/Login/user
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Email", "Password")] User user)
        {

            if (user.Email != null && user.Password != null)
            {
                HttpContext.Session.SetString("Email", (user.Email).ToString());
                HttpContext.Session.SetString("UserName", _User.GetAll().Result.SingleOrDefault(userId => userId.Email == user.Email).FirstName);
                if (!_searchEmail.SearchEmailORPassword(user.Email, user.Password))

                    return RedirectToAction(nameof(Index));

            }
            return View("Error");
        }
        // End Login Form Action
        [HttpPost]
        public IActionResult Comment(UserCommentsViewModel userComments)
        {
            if (userComments.CommentUser != null)
            {
                if (HttpContext.Session.GetString("UserName") != null)
                {

                    var comment = new Comment
                    {
                        Text = userComments.CommentUser,
                        UserId = _User.GetAll().Result.FirstOrDefault(user => user.FirstName == HttpContext.Session.GetString("UserName")).ID,

                    };

                    ModelState.Clear();
                    if (_comment.Create(comment).Result > 0)
                    {
                        HttpContext.Session.SetString("ID_Comment", comment.Id.ToString());
                        return RedirectToAction(nameof(New), "News", new { Id = HttpContext.Session.GetString("Route-ID") }); ;
                    }
                }
                else
                {
                    return RedirectToAction(nameof(Register));
                }

            }
            return View("Error");
        }
        [HttpGet]
        public IActionResult Logout()
        {
            return RedirectToAction(nameof(Register));
        }


        [HttpGet]
        public IActionResult DelComment(int Id)
        {
            if (Id != 0)
            {
                if (_comment.Delete(_comment.Get(Id).Result).Result > 0)
                {
                    return RedirectToAction(nameof(New), "News", new { Id = HttpContext.Session.GetString("Route-ID") });
                }
            }
            return RedirectToAction(nameof(New), "News", new { Id = HttpContext.Session.GetString("Route-ID") });
        }
      
      [HttpPost]
        public IActionResult ForgetPW(string Email)
        {
            if (!String.IsNullOrEmpty(Email))
            {
                User user = _User.GetAll().Result.SingleOrDefault(user => user.Email == Email);
                if (user != null)
                {

                }
            }
            return View(nameof(Index));
        }




    }
}


