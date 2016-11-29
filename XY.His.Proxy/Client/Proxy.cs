using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.ServiceModel;
using System.Web;
using System.ServiceModel.Channels;
using log4net;

namespace XY.His.Client
{
    public class Proxy
    {
        private const string EndPointName = "BasicHttpBinding_IServiceProvider";
        private const long MaxReceivedMessageSize = 65535000;
        private const int TimeOutMinutes = 10;
        private string address = "http://{0}:{1}/XY{2}.svc";

        protected string EndpointConfigurationName 
        {
            get { return EndPointName; } 
        }

        protected virtual string UserName { get; private set; }
        protected virtual string Password { get; private set; }
        protected virtual bool Credentials { get; private set; }
        
        public string Host { get; set; }
        public int Port { get; set; }        

        private TContract GetContract<TContract>()
        {
            ChannelFactory<TContract> ChannelFactory = new ChannelFactory<TContract>(EndpointConfigurationName);
            if (Credentials)
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);

                var clientCredentials = ChannelFactory.Credentials;
                clientCredentials.UserName.UserName = UserName;
                clientCredentials.UserName.Password = Password;
            }

            return ChannelFactory.CreateChannel();
        }

        public T GetProxy<T>()
        {
            string service = typeof(T).Name.Substring(1);
            string url = string.Format(address, Host, Port, service);
            return GetProxy<T>(url, BindingType.BasicHttpBinding);
        }

        public T GetProxy<T>(string url, BindingType bindingType)
        {
            if (string.IsNullOrWhiteSpace(url)) 
                throw new ArgumentNullException("Url can not be null or empty.");

            EndpointAddress address = new EndpointAddress(url);
            Binding binding = CreateBinding(bindingType);
            ChannelFactory<T> channelFactory = new ChannelFactory<T>(binding, address);
            return channelFactory.CreateChannel();
        }
        
        private Binding CreateBinding(BindingType bindingType)
        {
            switch (bindingType)
            {
                case BindingType.BasicHttpBinding:
                    return CreateBasicHttpBinding();                    

                case BindingType.WSHttpBinding:
                    return CreateWSHttpBinding();
                    
                case BindingType.NetTcpBinding:
                    return CreateNetTcpBinding();

                case BindingType.WebHttpBinding:
                    return CreateWebHttpBinding();               

                case BindingType.NetNamedPipeBinding:
                    return CreateNetNamedPipeBinding();

                case BindingType.WSDualHttpBinding:
                    return CreateWSDualHttpBinding();

                case BindingType.WSFederationHttpBinding:
                    return CreateWSFederationHttpBinding();

                default:
                    return CreateBasicHttpBinding();
            }
        }

        private static Binding CreateBasicHttpBinding() 
        {
            TimeSpan ts  = new TimeSpan(0, TimeOutMinutes, 0);

            BasicHttpBinding basicHttpBinding = new BasicHttpBinding() 
            {
                MaxBufferSize  = Int32.MaxValue,
                MaxBufferPoolSize = Int32.MaxValue,
                MaxReceivedMessageSize = Int32.MaxValue,
                ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas()
                {
                    MaxArrayLength = Int32.MaxValue,
                    MaxBytesPerRead = Int32.MaxValue,
                    MaxDepth = Int32.MaxValue,
                    MaxNameTableCharCount = Int32.MaxValue,
                    MaxStringContentLength = Int32.MaxValue,
                },
                CloseTimeout = ts,
                OpenTimeout = ts,
                ReceiveTimeout = ts,
                SendTimeout = ts
            };    

            return basicHttpBinding;
        }

        private static Binding CreateNetNamedPipeBinding()
        {
            NetNamedPipeBinding netNamedPipeBinding = new NetNamedPipeBinding()
            {
                MaxReceivedMessageSize = MaxReceivedMessageSize
            };

            return netNamedPipeBinding;
        }        

        private static Binding CreateNetTcpBinding()
        {
            NetTcpBinding netTcpBinding = new NetTcpBinding(SecurityMode.None) 
            {
                MaxReceivedMessageSize = MaxReceivedMessageSize
            };

            return netTcpBinding;
        }

        private static Binding CreateWSDualHttpBinding()
        {
            WSDualHttpBinding wsDualHttpBinding = new WSDualHttpBinding() 
            {
                MaxReceivedMessageSize = MaxReceivedMessageSize
            };

            return wsDualHttpBinding;
        }

        private static Binding CreateWebHttpBinding()
        {
            //WebHttpBinding ws = new WebHttpBinding();
            //ws.MaxReceivedMessageSize = MaxReceivedMessageSize;
            throw new NotImplementedException();
        }

        private static Binding CreateWSFederationHttpBinding()
        {
            WSFederationHttpBinding wsFederationHttpBinding = new WSFederationHttpBinding() 
            {
                MaxReceivedMessageSize = MaxReceivedMessageSize
            };
            
            return wsFederationHttpBinding;
        }

        private static Binding CreateWSHttpBinding()
        {
            WSHttpBinding wsHttpBinding = new WSHttpBinding(SecurityMode.None)
            {
                MaxReceivedMessageSize = MaxReceivedMessageSize
            };            
            wsHttpBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            wsHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
            return wsHttpBinding;
        }        
    }

    public enum BindingType
    {
        BasicHttpBinding = 1,
        WSHttpBinding = 2,
        NetTcpBinding = 3,
        WebHttpBinding = 4,
        //NetPeerTcpBinding = 5,
        NetNamedPipeBinding = 6,
        WSDualHttpBinding = 7,
        WSFederationHttpBinding = 8
    } 
}



