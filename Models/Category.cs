using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Must be Insert ?")]
        [StringLength(maximumLength: 20, MinimumLength = 5)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Must Be Set ?")]
       
        public string Description { get; set; }
        public virtual ICollection<New> News { get; set; }
    }
}
