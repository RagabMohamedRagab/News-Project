using Project_n9ws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.ViewModel
{
    public class UserCommentsViewModel
    {
        public UserCommentsViewModel()
        {
            this.Date = DateTime.Now;
        }
        public  string UserName { get; set; }
        public DateTime Date { get; set; }
        public string CommentUser { get; set; }
    }
}
