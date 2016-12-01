using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public interface IWcfConfiguration
    {
        System.ServiceModel.Channels.Binding CreateBinding();
    }

    public abstract class BindingFactory
    {
        protected BindingFactory() { }

        public virtual IWcfConfiguration Configure()
        {
            throw new NotImplementedException();
        }
    }
}
