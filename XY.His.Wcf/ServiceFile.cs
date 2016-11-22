using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace XY.His.Wcf
{
    public class ServiceFile : VirtualFile
    {
        public ServiceFile(string virtualPath)
            : base(virtualPath)
        { 
        }

        public string GetCallingServiceName
        {
            get
            {
                return base.VirtualPath.Replace(Constants.ServicePathSeparator, string.Empty)
                    .Replace(Constants.ServiceSuffix, string.Empty)
                    .TrimStart(Constants.ServicePrefix.ToCharArray());                
            }
        }

        public string GetService()
        {
            return this.GetCallingServiceName;
        }

        public override Stream Open()
        {
            var serviceDef = new MemoryStream();
            var defWriter = new StreamWriter(serviceDef);

            // Write host definition
            defWriter.Write("<%@ ServiceHost Language=\"C#\" Debug=\"true\" Service=\"" + this.GetService() + "\"  " +
                            "Factory=\"XY.His.Wcf.DynamicHostFactory, XY.His.Wcf\" %>");
            defWriter.Flush();

            serviceDef.Position = 0;
            return serviceDef;
        }
    }
}