using System;
using System.Collections.Generic;
using System.Linq;
using Docitcare_v2.Core.Domain;
using Docitcare_v2.Core.Repositories;
using System.Web;

namespace Docitcare_v2.Persistence.Repositories
{
    public class SuperUserRepository : Repository<SuperUserLogin>, ISuperUser
    {
        public SuperUserRepository(DocitcareDbContext context) : base(context)
        {

        }
        public DocitcareDbContext DocitcareDbContext
        {
            get { return Context as DocitcareDbContext; }
        }

        public SuperUserLogin ValidateCredentails(SuperUserLogin model)
        {
            return DocitcareDbContext.SuperUserLogins.SingleOrDefault(x => x.MobileNumber == model.MobileNumber && x.Password == model.Password);
        }
    }
}