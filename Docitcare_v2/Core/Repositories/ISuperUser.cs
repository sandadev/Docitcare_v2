using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Docitcare_v2.Core.Domain;
using Docitcare_v2.Core.Repositories;

namespace Docitcare_v2.Core.Repositories
{
   public interface ISuperUser : IRepository<SuperUserLogin>
    {
        SuperUserLogin ValidateCredentails(SuperUserLogin model);
    }
}
