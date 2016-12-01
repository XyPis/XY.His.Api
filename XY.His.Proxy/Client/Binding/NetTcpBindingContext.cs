using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class NetTcpBindingContext : IWcfConfiguration
    {        
        public System.ServiceModel.Channels.Binding CreateBinding()
        {
            NetTcpBinding netTcpBinding = new NetTcpBinding(SecurityMode.None)
            {
                MaxReceivedMessageSize = Constants.MaxReceivedMessageSize
            };

            return netTcpBinding;
        }
    }
}
