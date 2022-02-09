using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required,MaxLength(20),Column(TypeName ="nvarchar(20)")]
        public string Name { get; set; }
        [RegularExpression(@"[a-z A-Z 0-9] {5,10}\d{1,5}@[gmail|yahoo]\.com",ErrorMessage ="min Five charactries and max ten charactries"),Required,Display(Name="Your Email")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"*[A-Z a-z 0-9 _]")]
        public string Password { get; set; }
        [Display(Name="Country"),ForeignKey(nameof(Country))]
        public Nullable<int> CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
