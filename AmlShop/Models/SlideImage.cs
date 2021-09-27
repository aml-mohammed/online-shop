using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Models
{
    public class SlideImage
    {
        [Key]
        public int SlideImageId { get; set; }
        public string SlideTitle { get; set; }

        public string Slideimage { get; set; }

     
    }
}
