using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Docitcare_v2.Core.Domain;
using Docitcare_v2.Core.Repositories;

namespace Docitcare_v2.Persistence.Repositories
{
    public class UltraUserRepository : Repository<UltraUsers>, IUltraUserRepository
    {
        public UltraUserRepository(DocitcareDbContext context): base(context)
        {

        }
        public DocitcareDbContext DocitcareDbContext
        {
            get { return Context as DocitcareDbContext; }
        }

        public UltraUsers ValidateCredentails(UltraUsers model)
        {
           
                return DocitcareDbContext.UltraUsers.SingleOrDefault(x => x.MobileNumber == model.MobileNumber && x.Password==model.Password );
           
        }
    }
}
