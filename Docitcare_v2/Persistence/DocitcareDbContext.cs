using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Docitcare_v2.Core.Domain;

namespace Docitcare_v2.Persistence
{
    public class DocitcareDbContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UltraRole> UltraRole { get; set; }
        public DbSet<UltraUsers> UltraUsers{ get; set; }
        public DbSet<UltraRoleMapping> UltraRoleMappings { get; set; }
        public DbSet<SuperUserLogin> SuperUserLogins { get; set; }


        public DocitcareDbContext(): base("name=DocitcareDbContext")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
   
}