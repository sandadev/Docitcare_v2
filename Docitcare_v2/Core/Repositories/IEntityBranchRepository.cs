using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Docitcare_v2.Core.Domain;

namespace Docitcare_v2.Core.Repositories
{
   public interface IEntityBranchRepository : IRepository<EntityBranches>
    {
        void Update(EntityBranches entityBranch);
    }
}
