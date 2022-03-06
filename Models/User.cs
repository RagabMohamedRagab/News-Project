using Microsoft.AspNetCore.Http;
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
        [Required,MaxLength(20),Column(TypeName ="nvarchar(20)"),Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required, MaxLength(20), Column(TypeName = "nvarchar(20)"),Display(Name ="Last Name")]
        public string LastName { get; set; }
        //[RegularExpression(@"[a-z A-Z 0-9] {5,10}\d{1,5}@[gmail|yahoo]\.com", ErrorMessage = "min Five charactries and max ten charactries"), Required, Display(Name = "Your Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Column(TypeName="nvarchar(200)")]
        public string Image { get; set;}

        public IFormFile File { get; set; }
        [Column("Password",TypeName ="nvarchar(100)"),Required(ErrorMessage ="Enter Correct Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
        public string GetCountry { get; set; }
        [Display(Name="Country"),ForeignKey(nameof(CountryId))]
        public Nullable<int> CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
   
}
