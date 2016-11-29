using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class WSHttpBindingContext : IWcfBinding
    {
        public System.ServiceModel.Channels.Binding Build()
        {
            WSHttpBinding wsHttpBinding = new WSHttpBinding(SecurityMode.None)
            {
                MaxReceivedMessageSize = Constants.MaxReceivedMessageSize
            };
            wsHttpBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            wsHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
            
            return wsHttpBinding;
        }
    }
}
