using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Docitcare_v2.Core.Domain
{
    public class SuperUserLogin
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        [Required]
        public string Password { get; set; }
    }
}