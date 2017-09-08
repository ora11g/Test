using HisPlus.Contract;
using HisPlus.Domain;
using SmartElk.Antler.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Service
{
    public class BsGfxeService : IBsGfxeService
    {
        public BsGfxeInfo GetById(int id)
        {
            return UnitOfWork.Do(uow =>
            {
                uow.Repo<BsGfxeInfo>().GetById(id);
                var result = uow.Repo<BsGfxeInfo>().GetById(id);
                return result;
            });
        }

        public List<BsGfxeInfo> Query()
        {
            return UnitOfWork.Do(uow =>
            {
                
                //var result = uow.Repo<BsGfxeInfo>().GetById(id);
                return null;
            });

            //using (var session = this._sessionFactory.OpenSession())
            //{
            //    uow.
            //    var query = session.Query<Category>()
            //        .Cacheable()
            //        .CacheMode(CacheMode.Normal)
            //        .CacheRegion("AllCategories");
            //    var result = query.ToList();
            //}

        }
    }
}
