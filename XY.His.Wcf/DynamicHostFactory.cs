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
            string errMsg = string.Empty;

            var serviceType = ServiceConfig.ServiceTypes.Where(x => x.Name == constructorString).FirstOrDefault();
            if (serviceType == null)
            {
                errMsg = string.Format("No service named '{0}' was found in service config.", constructorString);
                throw new Exception(errMsg);
            }
           
            string contractName = string.Format("{0}{1}", ServiceConfig.ContractPrefix, serviceType.Name);

            var contractType = serviceType.GetInterfaces()
                .Where(x => x.Name == contractName)
                .FirstOrDefault();
            if (contractType == null)
            {
                throw new Exception(string.Format("Invalid contract type '{0}'", contractType.FullName));
            }

            ServiceHost host = new ServiceHost(serviceType, baseAddresses);

            foreach (Uri address in baseAddresses)
            {
                foreach (var type in serviceType.GetInterfaces()
                .Where(x => x.IsAssignableFrom(serviceType))
                .Where(x => x.Name == contractName))
                {
                    BasicHttpsBinding basicHttpsBinding = new BasicHttpsBinding();
                    basicHttpsBinding.Name = serviceType.Name;

                    var attribute = Attribute.GetCustomAttribute(contractType, typeof(ServiceContractAttribute));
                    var serviceAttribute = (ServiceContractAttribute)attribute;
                    if (serviceAttribute != null)
                    {
                        host.AddServiceEndpoint(type, basicHttpsBinding, address);
                    }
                }
            }
            
            
            //NetTcpBinding tcpBinding = new NetTcpBinding();                
            //tcpBinding.Security.Mode = SecurityMode.Transport;                
            //tcpBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Certificate;
            //host.AddServiceEndpoint(typeof(ICalculator), tcpBinding, "net.tcp://127.0.0.1:8888/CalculatorServiceTcp");
            if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
            {
                ServiceMetadataBehavior metadata = new ServiceMetadataBehavior();
                metadata.HttpGetEnabled = true;
                metadata.HttpGetUrl = baseAddresses[0];
                host.Description.Behaviors.Add(metadata);
            }

            //var serviceDebugBehavior = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            //serviceDebugBehavior.IncludeExceptionDetailInFaults = true;            

            return host;
        }

        bool IsDerivedOfGenericType(Type type, Type genericType)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericType)
                return true;

            if (type.BaseType != null)
            {
                return IsDerivedOfGenericType(type.BaseType, genericType);
            }
            return false;
        }

    }
}

//public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
//    {
//        // Load bin/services.dll
//        var asm = Assembly.Load("Services");
//        var serviceType = asm.GetType(constructorString);
//        var host = new ServiceHost(serviceType, baseAddresses);
 
//        // Add endpoints. (In this example only IHello interface)
//        foreach (Type contract in serviceType.GetInterfaces())
//        {
//            var attribute = (ServiceContractAttribute)
//                Attribute.GetCustomAttribute(contract, typeof(ServiceContractAttribute));
//            if (attribute != null)
//                host.AddServiceEndpoint(contract, new BasicHttpBinding(), "");
//        }
//        // Add metdata behavior for generating wsdl
//        var metadata = new ServiceMetadataBehavior();
//        metadata.HttpGetEnabled = true;
//        host.Description.Behaviors.Add(metadata);
             
//        return host;
//    }