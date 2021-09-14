using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Docitcare_v2.Core.Domain
{
    public class UltraRoleMapping
    {
        public int Id { get; set; }
        [Display(Name = "User ID")]
        public int UltraUserId { get; set; }
        public UltraUsers UltraUsers { get; set; }
        [Display(Name = "Role ID")]
        public int UltraRoleID { get; set; }
        public UltraRole UltraRole { get; set; }

    }
}