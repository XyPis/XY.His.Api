using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using XY.His.Contract.Service;
using XY.His.Contract.Message;
using Serialize.Linq.Nodes;

namespace XY.His.Contract
{    
    [ServiceContract]
    public interface IServiceProvider : IServiceBase
    {
        [OperationContract]
        Response Invoke(string assemblyName, string className, string methodName, params byte[] inputParam);
    }
}
