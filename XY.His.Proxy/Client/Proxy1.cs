using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.ServiceModel;
using System.Web.Services.Protocols;
using XY.His.Common;
using XY.His.Contract.Service;
using XY.His.Contract.Message;

namespace XY.His.Client
{
    public class Proxy1
    {
        private const string EndPointName = "BasicHttpBinding_IServiceProvider";

        private XY.His.Contract.IServiceProvider clientProxy;

        public Proxy1()
        {
            this.Initialize();
        }

        public Proxy1(Request request)
        {
            this.Initialize();
            this.Request = request;
        }

        private Request request;

        public Request Request
        {
            get { return request; }
            set
            {
                request = value;

                if (value.InputParam == null)
                {
                    value.InputParam = new object[0];
                }
            }
        }        

        private void Initialize()
        {
            clientProxy = GetContract<XY.His.Contract.IServiceProvider>();
        }              

        #region Execute
       
        public object Invoke()
        {
            try
            {                
                byte[] inputParam = Serializer.SerializeBinary(request.InputParam);
                DateTime dtbegin = DateTime.Now;
                object result = clientProxy.Invoke(request);
                
                object[] results = Serializer.DeserializeBinary((byte[])result);

                return results[0];
            }
            catch (SoapException soe)
            {
                return null;
            }
            catch (ThreadAbortException te)
            {
                return null; 
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Execute Error:\n  Assembly={0}\n  Method={1}.{2}\n  {3}", request.AssemblyName, request.ClassName, request.MethodName, ex.Message));
            }
        }

        public object Invoke(Request request)
        {
            this.Request = request;
            return Invoke();
        }

        public object Invoke(string assemblyName, string className, string methodName, object[] inputParam)
        {
            Request request = new Request()
            {
                AssemblyName = assemblyName,
                ClassName = className,
                MethodName = methodName,
                InputParam = inputParam
            };

            return Invoke(request);
        }
        
        #endregion
         
        protected string EndpointConfigurationName
        {
            get { return EndPointName; }
        }

        protected virtual string UserName { get; private set; }
        protected virtual string Password { get; private set; }
        protected virtual bool Credentials { get; private set; }

        public TContract GetContract<TContract>()
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
    }
}