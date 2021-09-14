using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Docitcare_v2.Core;
using Docitcare_v2.Core.Repositories;
using Docitcare_v2.Persistence.Repositories;

namespace Docitcare_v2.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DocitcareDbContext _context;
        public UnitOfWork(DocitcareDbContext context)
        {
            _context = context;
            Entities = new EntityRepository(_context);
            UltraUser = new UltraUserRepository(_context);
            SuperUser = new SuperUserRepository(_context);
        }
        public IEntityRepository Entities { get; private set; }
        public IEntityBranchRepository EntityBranch { get; private set; }
        public IUltraUserRepository UltraUser { get; private set; }

        public ISuperUser SuperUser { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}