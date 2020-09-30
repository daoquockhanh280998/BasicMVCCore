using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMvcCore3.n.Models
{
    public class ProductEditModel
    {
  
        public int ID { get; set; }
        [Required(ErrorMessage ="Name lỗi")]
        [StringLength(maximumLength:25,MinimumLength =3,ErrorMessage ="3 to 25")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string EmailID { get; set; }
        public decimal Rate { get; set; }
        public int Rating { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
