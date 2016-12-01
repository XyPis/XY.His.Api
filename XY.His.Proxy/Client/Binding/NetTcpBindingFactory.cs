using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class NetTcpBindingFactory : BindingFactory
    {
        public override IWcfConfiguration Configure()
        {
            return new NetTcpBindingContext();
        }

        private NetTcpBindingFactory() { }

        public static NetTcpBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static NetTcpBindingFactory _instance = new NetTcpBindingFactory();
        }
    }
}
