using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class NetNamedPipeBindingFactory : BindingFactory
    {
        public override IWcfBinding BuildBinding()
        {
            return new NetNamedPipeBindingContext();
        }

        private NetNamedPipeBindingFactory() { }

        public static NetNamedPipeBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static NetNamedPipeBindingFactory _instance = new NetNamedPipeBindingFactory();
        }
    }
}
