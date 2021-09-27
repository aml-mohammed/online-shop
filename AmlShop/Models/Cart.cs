using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Models
{
    public class Cart
    {
        [Key]
        public Guid CatrtId { get; set; }
        [ForeignKey("ProductId")]
        public int ProdcutId { get; set; }

        [ForeignKey("MemberId")]
        public int MemberId { get; set; }

        [ForeignKey("CartStatusId")]
        public int CartStatusId { get; set; }
       
    


    }
}
