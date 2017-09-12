using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using HisPlus.Contract;
using HisPlus.Domain;
using HisPlus.Mapping;
using NHibernate;
using NHibernate.Caches.SysCache;
using NHibernate.Cfg;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Service
{
    public class BsGfxeService : IBsGfxeService
    {        
        public BsGfxeInfo GetById(ISessionFactory sessionFactory, int id)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                BsGfxeInfo gfxe = session.Get<BsGfxeInfo>(1);
                Console.WriteLine(gfxe.Id + " : " + gfxe.Name);

                BsGfxeInfo gfxe1 = session.Get<BsGfxeInfo>(1);
                Console.WriteLine(gfxe1.Id + " : " + gfxe1.Name);
                return gfxe;
            }            
        }

        public List<BsGfxeInfo> Query(ISessionFactory sessionFactory)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                var query = session.Query<BsGfxeInfo>()
                    .Cacheable()
                    .CacheMode(CacheMode.Normal)
                    .CacheRegion("All")
                    ;

                return query.ToList();
            }
        }
    }
}
