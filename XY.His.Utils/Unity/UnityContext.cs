using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace XY.His.Utils.Unity
{
    internal sealed class UnityContext
    {
        private UnityContext() { }

        public static IUnityContainer Instance
        {
            get { return Nested._instance; }
        }

        internal class Nested
        {           
            static Nested() { }

            internal readonly static IUnityContainer _instance = new UnityContainer();
        }
    }
}
