using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XY.His.Server.ServiceActivation
{
    public class ServiceConfig
    {
        private const string ServiceHostDefinition = "<%@ ServiceHost Language=\"C#\" Debug=\"{0}\" Service=\"{1}\" Factory=\"{2}\" %>";        

        public static string Prefix 
        {
            get { return "XY"; }
        }

        public static string Suffix 
        {
            get { return ".svc"; } 
        }

        public static string PathSeparator 
        {
            get { return "/"; } 
        }

        public static string ContractPrefix 
        {
            get { return "I"; } 
        }

        public static IList<string> Assemblies 
        {
            get 
            {                
                var assemblies = new List<string>();
                assemblies.Add("XY.His.Service");

                return assemblies;
            }
        }

        public static bool ServiceDebug 
        {
            get { return true; }
        }

        public static Type HostFactoryType
        {
            get;
            set;
        }

        public static string ServiceHostDef 
        {
            get { return ServiceHostDefinition; } 
        }

        public static Type[] ServiceTypes { get; set; }

        public static Type[] ContractTypes { get; set; }
    }
}