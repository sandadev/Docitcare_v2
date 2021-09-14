using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Docitcare_v2.Core.Domain;
using Docitcare_v2.Core.Repositories;

namespace Docitcare_v2.Core.Repositories
{
    public interface IUltraUserRepository: IRepository<UltraUsers>
    {
        UltraUsers ValidateCredentails(UltraUsers model);
    }
}