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
        readonly NewsContextDb _NewsContextDb;
        public CommentViewComponent(NewsContextDb NewsContextDb)
        {
            _NewsContextDb = NewsContextDb;
        }
        public  IViewComponentResult Invoke()
        {
            IQueryable<UserCommentsViewModel> userComments =
                   _NewsContextDb.Comments
                   .Select(comment =>new UserCommentsViewModel 
                   {
                       UserName = comment.Users.FirstName,
                       CommentUser = comment.Text 
                   });
            return View(userComments);
        }
    }
}
