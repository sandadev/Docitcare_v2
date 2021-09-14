using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Docitcare_v2.Core.Domain;
using Docitcare_v2.Core.Repositories;

namespace Docitcare_v2.Persistence.Repositories
{
    public class EntityBranchRepository : Repository<EntityBranches>,IEntityBranchRepository
    {
        public EntityBranchRepository(DocitcareDbContext context) : base(context)
        {

        }
        public DocitcareDbContext DocitcareDbContext
        {
            get { return Context as DocitcareDbContext; }
        }

        public void Update(EntityBranches entityBranch)
        {
            throw new NotImplementedException();
        }
    }
}