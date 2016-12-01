using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace XY.His.Server.ServiceActivation
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
                return base.VirtualPath
                    .Replace(ServiceConfig.PathSeparator, string.Empty)
                    .Replace(ServiceConfig.Suffix, string.Empty)
                    .TrimStart(ServiceConfig.Prefix.ToCharArray());                
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
            string serviceName = this.GetService();
            var type = ServiceConfig.HostFactoryType;
            var typeName = string.Format("{0}, {1}", type.FullName, type.Assembly.FullName);
            var serviceHostDef = string.Format(ServiceConfig.ServiceHostDef, ServiceConfig.ServiceDebug, serviceName, typeName);                            

            defWriter.Write(serviceHostDef);
            defWriter.Flush();

            serviceDef.Position = 0;
            
            return serviceDef;
        }
    }
}