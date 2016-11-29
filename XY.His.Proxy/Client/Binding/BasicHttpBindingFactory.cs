using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class BasicHttpBindingFactory : BindingFactory
    {
        public override IWcfBinding BuildBinding()
        {
            return new BasicHttpBindingContext();
        }

        private BasicHttpBindingFactory() { }

        public static BasicHttpBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static BasicHttpBindingFactory _instance = new BasicHttpBindingFactory();
        }
    }
}
