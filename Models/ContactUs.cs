using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class ContactUs
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Enter Name!!")]
        public string Name { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Subject!!")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Enter Message!!")]
        public string Message { get; set; }
    }
}
