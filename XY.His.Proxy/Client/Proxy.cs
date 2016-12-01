using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.ServiceModel;
using System.Web;
using System.ServiceModel.Channels;
using XY.His.Client.Binding;
using log4net;

namespace XY.His.Client
{
    public class Proxy
    {             
        public string Host { get; set; }
        public int Port { get; set; }
        public BindingType BindingType { get; set; }

        public T GetProxy<T>()
        {
            string service = typeof(T).Name.Substring(1);
            string url = string.Format(Constants.Uri, Host, Port, service);
            return GetProxy<T>(url, BindingType.BasicHttpBinding);
        }

        public T GetProxy<T>(string url, BindingType bindingType)
        {
            if (string.IsNullOrWhiteSpace(url)) 
                throw new ArgumentNullException("Url can not be null or empty.");

            EndpointAddress address = new EndpointAddress(url);
            System.ServiceModel.Channels.Binding binding = Configuration(bindingType).CreateBinding();
            ChannelFactory<T> channelFactory = new ChannelFactory<T>(binding, address);

            return channelFactory.CreateChannel();
        }

        private IWcfConfiguration Configuration(BindingType bindingType)
        {
            switch (bindingType)
            {
                case BindingType.BasicHttpBinding:
                    return Binding.BasicHttpBindingFactory.Instance.Configure();

                case BindingType.NetNamedPipeBinding:
                    return Binding.NetNamedPipeBindingFactory.Instance.Configure();

                case BindingType.NetTcpBinding:
                    return Binding.NetTcpBindingFactory.Instance.Configure();

                case BindingType.WebHttpBinding:
                    return Binding.WebHttpBindingFactory.Instance.Configure();

                case BindingType.WSDualHttpBinding:
                    return Binding.WSDualHttpBindingFactory.Instance.Configure();

                case BindingType.WSFederationHttpBinding:
                    return Binding.WSFederationHttpBindingFactory.Instance.Configure();

                case BindingType.WSHttpBinding:
                    return Binding.WSHttpBindingFactory.Instance.Configure();

                default:
                    return Binding.BasicHttpBindingFactory.Instance.Configure();
            }
        }          
    }
}



