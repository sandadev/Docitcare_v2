using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Docitcare_v2.Core.Domain
{
    public class Role
    {
        [Required]
        [Display(Name = "Role ID")]
        public int RoleID { get; set; }
        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}