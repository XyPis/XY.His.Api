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
namespace XY.His.Client
{
    public class ServiceProxy
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static Response CallService<T>(Action<T> action)
            where T : IServiceBase
        {
            T serviceProxy = GetProxy<T>();
            
            return ProcessRequest(serviceProxy, action);
        }

        public static Response CallService<T, TResult>(Func<T, TResult> func)
            where T : IServiceBase
        {
            T serviceProxy = GetProxy<T>();

            return ProcessRequest(serviceProxy, func);
        }
        
        //private static Response ProcessRequest(Request request)
        //{
        //    try
        //    {                
        //        XY.His.Contract.IServiceProvider serviceProvider = GetProxy<XY.His.Contract.IServiceProvider>();
                             
        //        byte[] inputParam = Serializer.SerializeBinary(request.InputParam);
                                                
        //        Response response = serviceProvider.Invoke(request.AssemblyName, request.ClassName, request.MethodName, inputParam);
        //        if (response.Status == ResponseStatus.OK)
        //        {                    
        //            object[] results = Serializer.DeserializeBinary((byte[])response.Result);

        //            //设置结果到响应
        //            response.Result = results[0];
        //        }

        //        //返回服务处理响应
        //        return response;
        //    }
        //    catch (SoapException soe)
        //    {
        //        //TODO:
        //        return null;
        //    }
        //    catch (ThreadAbortException te)
        //    {
        //        //TODO:
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(string.Format("Execute Error:\n  Assembly={0}\n  Method={1}.{2}\n  {3}", request.AssemblyName, request.ClassName, request.MethodName, ex.Message));
        //    }
        //}

        private static T GetProxy<T>()
            where T : IServiceBase
        {
            try
            {
                return Proxy.GetProxy<T>();
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("GetProxy<{0}> Exception: {1} \n{2}", typeof(T), GetErrMsg(ex), ex.StackTrace);
                throw;
            }
        }

        private static Response ProcessRequest<T>(T proxy, Action<T> action)
             where T : IServiceBase
        {
            string errMsg = string.Empty;

            Response response = new Response() 
            {
                Status = ResponseStatus.Error,
                Message = string.Empty
            };

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
                response.Message = errMsg;
                if (response.Status == ResponseStatus.Error)
                {
                    Log.Error(response.Message);

                    try
                    {
                        (proxy as IClientChannel).Abort();
                    }
                    catch (Exception e)
                    {
                        Log.Error(e.Message);
                    }
                }
            }

            return response;
        }

        private static Response ProcessRequest<T, TResult>(T proxy, Func<T, TResult> func)
             where T : IServiceBase
        {
            string errMsg = string.Empty;

            Response response = new Response() 
            {
                Status = ResponseStatus.Error,
                Message = string.Empty
            };            

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
                response.Message = errMsg;

                if (response.Status == ResponseStatus.Error)
                {
                    Log.Error(response.Message);
                    try
                    {
                        (proxy as IClientChannel).Abort();
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
            
            string errMsg = (ex == null) ? 
                string.Empty : string.Format("{0} Error: {1} \n{2}", ex.GetType().Name, ex.Message, ex.StackTrace);

            return errMsg;
        }
    }
}
