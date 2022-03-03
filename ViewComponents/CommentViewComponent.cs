using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_n9ws.Models;
using Project_n9ws.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.ViewComponents
{
    public class CommentViewComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
 
            return View();
        }
    }
}
