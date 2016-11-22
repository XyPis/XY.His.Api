using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.ServiceModel;
using System.Linq;
using System.Web;
using System.ServiceModel.Channels;
using XY.His.Common;
using XY.His.Contract.Service;
using XY.His.Contract.Message;

namespace XY.His.Client
{
    /// <summary>
    /// 动态调用WCF的工具类库
    /// </summary>
    public class InvokeContext
    {
        #region Wcf服务工厂
        public static T CreateWCFServiceByURL<T>()
        {
            string url = string.Format("http://localhost:8088/XY{0}.svc", typeof(T).Name.Substring(1));

            return CreateWCFServiceByURL<T>(url, "basichttpbinding");
        }

        public static T CreateWCFServiceByURL<T>(string url, string bing)
        {
            if (string.IsNullOrEmpty(url)) 
                throw new NotSupportedException("this url isn`t Null or Empty!");
            
            EndpointAddress address = new EndpointAddress(url);
            Binding binding = CreateBinding(bing);
            ChannelFactory<T> factory = new ChannelFactory<T>(binding, address);
            return factory.CreateChannel();
        }
        #endregion

        #region 创建传输协议
        /// <summary>
        /// 创建传输协议
        /// </summary>
        /// <param name="binding">传输协议名称</param>
        /// <returns></returns>
        private static Binding CreateBinding(string binding)
        {
            Binding bindinginstance = null;
            if (binding.ToLower() == "basichttpbinding")
            {
                BasicHttpBinding ws = new BasicHttpBinding();
                ws.MaxBufferSize = Int32.MaxValue;
                ws.MaxBufferPoolSize = Int32.MaxValue;
                ws.MaxReceivedMessageSize = Int32.MaxValue;
                ws.ReaderQuotas.MaxArrayLength = Int32.MaxValue;
                ws.ReaderQuotas.MaxBytesPerRead = Int32.MaxValue;
                ws.ReaderQuotas.MaxDepth = Int32.MaxValue;
                ws.ReaderQuotas.MaxNameTableCharCount = Int32.MaxValue;
                ws.ReaderQuotas.MaxStringContentLength = Int32.MaxValue;
                ws.CloseTimeout = new TimeSpan(0, 10, 0);
                ws.OpenTimeout = new TimeSpan(0, 10, 0);
                ws.ReceiveTimeout = new TimeSpan(0, 10, 0);
                ws.SendTimeout = new TimeSpan(0, 10, 0);

                bindinginstance = ws;
            }
            else if (binding.ToLower() == "netnamedpipebinding")
            {
                NetNamedPipeBinding ws = new NetNamedPipeBinding();
                ws.MaxReceivedMessageSize = 65535000;
                bindinginstance = ws;
            }
            else if (binding.ToLower() == "netpeertcpbinding")
            {
                NetPeerTcpBinding ws = new NetPeerTcpBinding();
                ws.MaxReceivedMessageSize = 65535000;
                bindinginstance = ws;
            }
            else if (binding.ToLower() == "nettcpbinding")
            {
                NetTcpBinding ws = new NetTcpBinding();
                ws.MaxReceivedMessageSize = 65535000;
                ws.Security.Mode = SecurityMode.None;
                bindinginstance = ws;
            }
            else if (binding.ToLower() == "wsdualhttpbinding")
            {
                WSDualHttpBinding ws = new WSDualHttpBinding();
                ws.MaxReceivedMessageSize = 65535000;

                bindinginstance = ws;
            }
            else if (binding.ToLower() == "webhttpbinding")
            {
                //WebHttpBinding ws = new WebHttpBinding();
                //ws.MaxReceivedMessageSize = 65535000;
                //bindinginstance = ws;
            }
            else if (binding.ToLower() == "wsfederationhttpbinding")
            {
                WSFederationHttpBinding ws = new WSFederationHttpBinding();
                ws.MaxReceivedMessageSize = 65535000;
                bindinginstance = ws;
            }
            else if (binding.ToLower() == "wshttpbinding")
            {
                WSHttpBinding ws = new WSHttpBinding(SecurityMode.None);
                ws.MaxReceivedMessageSize = 65535000;
                ws.Security.Message.ClientCredentialType = System.ServiceModel.MessageCredentialType.Windows;
                ws.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.Windows;
                bindinginstance = ws;
            }
            return bindinginstance;

        }
        #endregion

    }
}