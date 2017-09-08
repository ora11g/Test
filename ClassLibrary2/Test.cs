using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Test : ITest
    {
        public string GetString()
        {
            return "OK";
        }
    }
}
