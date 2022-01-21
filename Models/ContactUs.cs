using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class ContactUs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage ="Enter Name!!")]
        [StringLength(maximumLength: 20, MinimumLength = 5)]
        public string Name { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        [Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Subject!!")]
      
        public string Subject { get; set; }
        [Required(ErrorMessage = "Enter Message!!")]
       
        public string Message { get; set; }
    }
}
