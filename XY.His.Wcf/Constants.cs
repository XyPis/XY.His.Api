using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XY.His.Wcf
{
    public class Constants
    {
        public const string ServicePrefix = "XY";
        public const string ServiceSuffix = ".svc";
        public const string ServicePathSeparator = "/";

        public const string ContractPrefix = "I";

        public const string ServiceAssembly = "XY.His.Service";
        public const bool ServiceHostDebug = true;
        public const string ServiceHostFactory = "XY.His.Wcf.DynamicHostFactory, XY.His.Wcf";
        public const string ServiceHostDefinition = "<%@ ServiceHost Language=\"C#\" Debug=\"{0}\" Service=\"{1}\" Factory=\"{2}\" %>";        
    }
}