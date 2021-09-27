using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Models
{
    public class MemberRole
    {
        [Key]
        public int MemberRoleId { get; set; }
        [ForeignKey("MemberId")]
       
        public Member member { get; set; }
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
      
    



    }
}
