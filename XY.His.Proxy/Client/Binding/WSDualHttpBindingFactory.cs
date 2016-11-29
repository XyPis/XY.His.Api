using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class WSDualHttpBindingFactory : BindingFactory
    {
        public override IWcfBinding BuildBinding()
        {
            return new WSDualHttpBindingContext();
        }

        private WSDualHttpBindingFactory() { }

        public static WSDualHttpBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static WSDualHttpBindingFactory _instance = new WSDualHttpBindingFactory();
        }
    }
}
