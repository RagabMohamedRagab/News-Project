using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws.Models
{
    public class New
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="*Title*")]
        [StringLength(maximumLength: 20, MinimumLength = 5)]
        public string Title { get; set; }
        [Column(TypeName = "datetime2(7)")]
        public DateTime Date { get; set; }
        
      
        public string Image { get; set; }
        [Required(ErrorMessage ="Required")]
        [StringLength(maximumLength: 20, MinimumLength = 5)]
        public string Topic { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
