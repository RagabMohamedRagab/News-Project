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
        public  User Users { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
