using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        string GetString();
    }
}
