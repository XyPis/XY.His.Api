using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XY.His.Wcf
{
    public class ServiceConfig
    {
        public static string ServicePrefix { get; set; }

        public static string ServiceSuffix { get; set; }

        public static string ServicePathSeparator { get; set; }

        public static string ContractPrefix { get; set; }

        public static IList<string> ServiceAssembly { get; set; }

        public static bool ServiceHostDebug { get; set; }

        public static string ServiceHostFactory { get; set; }

        public static string ServiceHostDefinition { get; set; }

        public static IDictionary<string, Type> ServiceTypes { get; set; }
    }
}