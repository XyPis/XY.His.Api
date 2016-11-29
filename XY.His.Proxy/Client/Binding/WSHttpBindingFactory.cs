using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class WSHttpBindingFactory : BindingFactory
    {
        public override IWcfBinding BuildBinding()
        {
            return new WSHttpBindingContext();
        }

        private WSHttpBindingFactory() { }

        public static WSHttpBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static WSHttpBindingFactory _instance = new WSHttpBindingFactory();
        }
    }
}
