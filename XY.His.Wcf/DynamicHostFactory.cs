using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace XY.His.Wcf
{
    public class DynamicHostFactory : ServiceHostFactory
    {
        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {            
            ServiceHost host = null;
            string errMsg = string.Empty;

            var types = ServiceConfig.ServiceTypes.Where(x => x.Key == constructorString);
            if (types == null || types.Count() == 0)
            {
                errMsg = "No service was found in service config.";
                throw new Exception(errMsg);
            }

            if (types.Count() > 1)
            {
                errMsg = string.Format("Duplicated service '{0}' was found in service config.", types.LastOrDefault().Key);
                throw new Exception(errMsg);
            }

            var serviceType = types.FirstOrDefault().Value;

            string contractName = string.Format("{0}{1}", ServiceConfig.ContractPrefix, serviceType.Name);

            var contract = serviceType.GetInterfaces()
                .Where(x => x.Name == contractName)
                .FirstOrDefault();

            if (contract != null) 
            {
                host = new ServiceHost(serviceType, baseAddresses);
                                   
                var attribute = Attribute.GetCustomAttribute(contract, typeof(ServiceContractAttribute));
                var serviceAttribute = (ServiceContractAttribute)attribute;

                if (serviceAttribute != null)
                {
                    host.AddServiceEndpoint(contract, new BasicHttpBinding(), "");
                }
            }
             
            var metadata = new ServiceMetadataBehavior();
            metadata.HttpGetEnabled = true;
            host.Description.Behaviors.Add(metadata);

            return host;
        }
    }
}