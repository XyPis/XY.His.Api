using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public interface IWcfBinding
    {
        System.ServiceModel.Channels.Binding Build();
    }

    public abstract class BindingFactory
    {
        protected BindingFactory() { }

        public virtual IWcfBinding BuildBinding() 
        {
            throw new NotImplementedException();
        }
    }
}
