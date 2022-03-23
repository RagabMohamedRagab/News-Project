using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public int Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int Password { get; set; }
    }
}
