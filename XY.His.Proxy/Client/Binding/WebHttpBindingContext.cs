using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class WebHttpBindingContext : IWcfConfiguration
    {
        public System.ServiceModel.Channels.Binding CreateBinding()
        {
            throw new NotImplementedException();
        }
    }
}
