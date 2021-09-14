using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Docitcare_v2.Core.Domain
{
    public class UltraUsers
    {
        [Key]
        [Display(Name = "User ID")]
        public int UltraUserId { get; set; }
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        public string Password{ get; set; }
        public string Email { get; set; }
        [Display(Name = "Mobile Number")]
        public long MobileNumber { get; set; }
        public string Address { get; set; }



    }
}