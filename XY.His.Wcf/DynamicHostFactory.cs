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
            var assembly = Assembly.Load(Constants.ServiceAssembly);
            var type = assembly.GetTypes().Where(x => x.Name == constructorString).FirstOrDefault();
            var serviceType = assembly.GetType(type.FullName);

            string contractName = string.Format("{0}{1}", Constants.ContractPrefix, serviceType.Name);

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