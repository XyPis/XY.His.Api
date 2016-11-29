using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY.His.Client.Binding
{
    public class Constants
    {
        public const long MaxReceivedMessageSize = 65535000;
        public const int TimeoutMinutes = 10;
        public const string Uri = "http://{0}:{1}/XY{2}.svc";
    }
}
