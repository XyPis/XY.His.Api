using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class NetTcpBindingContext : IWcfBinding
    {        
        public System.ServiceModel.Channels.Binding Build()
        {
            NetTcpBinding netTcpBinding = new NetTcpBinding(SecurityMode.None)
            {
                MaxReceivedMessageSize = Constants.MaxReceivedMessageSize
            };

            return netTcpBinding;
        }
    }
}
