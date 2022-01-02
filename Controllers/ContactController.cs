using Microsoft.AspNetCore.Mvc;
using Project_n9ws.Data;
using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Controllers
{
    public class ContactController : Controller
    {
        readonly INews<ContactUs> _contact;

        public ContactController(INews<ContactUs> contact)
        {
            _contact = contact;
        }

        [HttpGet] // Get : Contact/Contactus
        public IActionResult Contactus()
        {
            return View();
        }
        [HttpPost] // Post : Contact/Contactus 
        [ValidateAntiForgeryToken]
        public IActionResult Contactus([FromForm] ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                _contact.Create(contactUs);
                ModelState.Clear();
                return View();
            }

            return View(contactUs);
        }










    }
}
