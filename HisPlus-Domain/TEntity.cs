using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Domain
{
    public class Entity<TId>
    {
        public virtual TId Id { get; set; }
    }
}
