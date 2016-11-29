using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class WSFederationHttpBindingContext : IWcfBinding
    {        
        public System.ServiceModel.Channels.Binding Build()
        {
            WSFederationHttpBinding wsFederationHttpBinding = new WSFederationHttpBinding()
            {
                MaxReceivedMessageSize = Constants.MaxReceivedMessageSize
            };

            return wsFederationHttpBinding;
        }
    }
}
