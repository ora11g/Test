using HisPlus.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Contract
{
    public interface IBsGfxeService
    {
        BsGfxeInfo GetById(ISessionFactory sessionFactory, int id);

        List<BsGfxeInfo> Query(ISessionFactory sessionFactory);
    }
}
