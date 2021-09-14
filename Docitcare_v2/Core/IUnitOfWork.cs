using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Docitcare_v2.Core.Repositories;

namespace Docitcare_v2.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IEntityRepository Entities { get; }
        ISuperUser SuperUser { get; }

        IEntityBranchRepository EntityBranch { get; }
        IUltraUserRepository UltraUser { get; }
        int Complete();
    }
}