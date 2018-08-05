using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{  
    [ServiceContract(Name = "IHelloService")]
    public interface IHelloServiceChanged
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
