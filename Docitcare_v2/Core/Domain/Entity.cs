using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Docitcare_v2.Core.Domain
{
    public class Entity
    {
        [Required]
        [Display(Name = "Entity Id")]
        public int EntityId { get; set; }
        [Required]
        [Display(Name = "Hospital Name")]
        public string HospitalName { get; set; }
        [Required]
        [Display(Name = "Holder First Name")]
        public string HolderFirstName { get; set; }
        [Required]
        [Display(Name = "Holder Last Name")]
        public string HolderLastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contact Number1")]
        public long HospitalContactNumber1 { get; set; }
        [Display(Name = "Contact Number2")]
        public long HospitalContactNumber2 { get; set; }
        [Required]
        [Display(Name = "Contact Person")]
        public string ContactPersonName { get; set; }
        [Required]
        [Display(Name = "Contact Person Phone Number")]
        public long ContactPersonPhoneNumber { get; set; }
        [Required]
        [Display(Name = "Hospital Address")]
        public string Address { get; set; }
         [Required]
         [Display(Name ="Mobile Number")]
        public long MobileNumber { get; set; }

        [Display(Name = "Established Year")]
        public int EstablishedYear { get; set; }
        [Required]
        [Display(Name = "Register Date")]
        public DateTime RegisteredDate { get; set; }
        [NotMapped]
        public string Branches { get; set; }
    }
}