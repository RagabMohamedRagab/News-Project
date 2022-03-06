using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Must be insert")]
        public string Text { get; set; }

        public int? UserId { get; set; }
        public virtual User Users { get; set; }
    }
}
