using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class WSFederationHttpBindingFactory : BindingFactory
    {
        public override IWcfConfiguration Configure()
        {
            return new WSFederationHttpBindingContext();
        }

        private WSFederationHttpBindingFactory() { }

        public static WSFederationHttpBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static WSFederationHttpBindingFactory _instance = new WSFederationHttpBindingFactory();
        }

    }
}
