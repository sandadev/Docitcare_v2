using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Docitcare_v2.Core.Domain
{
    public class EntityBranches
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public Entity Entiy { get; set; }
        public int EntityID { get; set; }
    }
}