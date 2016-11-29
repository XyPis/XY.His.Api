using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XY.His.Client.Binding
{
    public class BasicHttpBindingContext : IWcfBinding
    {        
        public System.ServiceModel.Channels.Binding Build()
        {
            TimeSpan ts = new TimeSpan(0, Constants.TimeoutMinutes, 0);

            BasicHttpBinding basicHttpBinding = new BasicHttpBinding()
            {
                MaxBufferSize = Int32.MaxValue,
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
    }
}
