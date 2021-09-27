using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId  { get; set; }
        public string ProductName { get; set; }
        [ForeignKey("CatId")]
        public int CatId { get; set; }
        public bool IsActive { get; set; }
         public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModefiedDate { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public bool IsFeatured { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }

     
    }
}
