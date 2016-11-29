using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY.His.Client.Binding
{
    public enum BindingType
    {
        BasicHttpBinding = 1,
        WSHttpBinding = 2,
        NetTcpBinding = 3,
        WebHttpBinding = 4,
        //NetPeerTcpBinding = 5,
        NetNamedPipeBinding = 6,
        WSDualHttpBinding = 7,
        WSFederationHttpBinding = 8
    } 
}
