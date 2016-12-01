using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using XY.His;
using System.Reflection;
using System.ServiceModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services.Protocols;
using XY.His.Contract.Service;
using XY.His.Contract;
using XY.His.Contract.Message;
using XY.His.Utils.Unity;
using XY.His.Utils;
using log4net;
using Serialize.Linq.Extensions;
using Serialize.Linq.Nodes;
using Serialize.Linq.Serializers;
using Serialize.Linq.Factories;
using XY.His.Client.Binding;

namespace XY.His.Client
{
    public class ServiceProxy
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                
        public static int Port = 50410;
        public static string Host = "192.168.1.214";
        public static BindingType BindingType = Binding.BindingType.BasicHttpBinding;

        public static Response CallService<T>(Action<T> action)
            where T : IServiceBase
        {
            T serviceProxy = ClientProxy<T>(Host, Port, BindingType).GetProxy<T>();
         
            return Process(serviceProxy, action);
        }

        public static Response CallService<T, TResult>(Func<T, TResult> func)
            where T : IServiceBase
        {
            T serviceProxy = ClientProxy<T>(Host, Port, BindingType).GetProxy<T>();

            return Process(serviceProxy, func);
        }

        private static Proxy ClientProxy<T>(string host, int port, BindingType bindingType)
        {
            Proxy proxy = new Proxy()
            {
                Host = host,
                Port = port,
                BindingType = bindingType
            };
            
            return proxy;
        }

        private static Response Process<T>(T proxy, Action<T> action)
             where T : IServiceBase
        {
            string errMsg = string.Empty;

            Response response = new Response() 
            {
                Status = ResponseStatus.Error,
                Message = string.Empty
            };

            using (proxy)
            try
            {
                action(proxy);
                (proxy as IClientChannel).Close();
                response.Status = ResponseStatus.OK;
            }
            catch (System.ServiceModel.FaultException fe)
            {
                errMsg = GetErrMsg(fe);
            }
            catch (System.ServiceModel.CommunicationException ce)
            {
                errMsg = GetErrMsg(ce);
            }
            catch (TimeoutException te)
            {
                errMsg = GetErrMsg(te);
            }
            catch (Exception ex)
            {
                errMsg = GetErrMsg(ex);
            }
            finally
            {                
                if (response.Status == ResponseStatus.Error)
                {
                    response.Message = errMsg;
                    Log.Error(errMsg);

                    try
                    {
                        (proxy as IClientChannel).Abort();
                        proxy.Dispose();
                    }
                    catch (Exception e)
                    {
                        Log.Error(e.Message);
                    }
                }
            }

            return response;
        }

        private static Response Process<T, TResult>(T proxy, Func<T, TResult> func)
             where T : IServiceBase
        {
            string errMsg = string.Empty;

            Response response = new Response() 
            {
                Status = ResponseStatus.Error,
                Message = string.Empty
            };          
  
            using (proxy)
            try
            {
                response.Result = func(proxy);
                (proxy as IClientChannel).Close();
                response.Status = ResponseStatus.OK;
            }
            catch (FaultException<CommonFaultContract> fe)
            {
                errMsg = fe.Detail.Message;
            }
            catch (System.ServiceModel.CommunicationException ce)
            {
                errMsg = GetErrMsg(ce);
            }
            catch (TimeoutException te)
            {
                errMsg = GetErrMsg(te);
            }
            catch (Exception ex)
            {
                errMsg = GetErrMsg(ex);
            }
            finally
            {
                if (response.Status == ResponseStatus.Error)               
                {
                    response.Message = errMsg;
                    Log.Error(errMsg);
                    try
                    {
                        (proxy as IClientChannel).Abort();
                        proxy.Dispose();
                    }
                    catch (Exception e)
                    {
                        Log.Error(e.Message);
                    }
                }
            }

            return response;
        }

        private static string GetErrMsg(Exception ex)
        {
            while(ex.InnerException != null)
            {
                ex = ex.InnerException;
            }

            if (ex == null)
            {
                return string.Empty;
            }
            
            return string.Format("{0} Error: {1} \n{2}", ex.GetType().Name, ex.Message, ex.StackTrace);
        }
    }
}
