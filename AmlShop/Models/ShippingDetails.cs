using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Models
{
    public class ShippingDetails
    {
        [Key]
        public int ShippingDetailId { get; set; }
        [ForeignKey("MemberId")]
        public int MemberId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public int OrderId { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentType { get; set; }

    }
}
