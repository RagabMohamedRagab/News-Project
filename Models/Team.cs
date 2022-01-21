using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Required Val"),Column(TypeName ="nvarchar(20)"),StringLength(maximumLength:20,MinimumLength =5)]
        public string Name { get; set; }
        [Required,MaxLength(20)]
        public string JopTitle { get; set; }
       
        public string Image { get; set; }
    }
}
