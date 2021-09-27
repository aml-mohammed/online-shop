using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Models
{
    public class CategoryDetails
    {
        public int CatId { get; set; }
        [Required(ErrorMessage ="Category name is rquired")]
        [StringLength(100,ErrorMessage =" min 3 and min 5 max 100 characters are allowed",MinimumLength =3) ]
        public string CatName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

    }
  
}
