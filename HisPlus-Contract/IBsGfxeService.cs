using HisPlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Contract
{
    public interface IBsGfxeService
    {
        BsGfxeInfo GetById(int id);

        List<BsGfxeInfo> Query();
    }
}
