using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using XY.His;
using System.Reflection;
using System.ServiceModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services.Protocols;
using log4net;
using XY.His.Contract.Service;
using XY.His.Utils.Unity;
using XY.His.Contract;
using XY.His.Contract.Message;
using XY.His.Common;
using Serialize.Linq.Extensions;
using Serialize.Linq.Nodes;
using Serialize.Linq.Serializers;
using Serialize.Linq.Factories;

namespace XY.His.Client
{
    public class ServiceWrapper
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //public static Response Invoke<T>(Expression<Action<T>> action)
        //    where T : IServiceBase
        //{
            
        //    T proxy = GetProxy<XY.His.Contract.IServiceProvider>();
        //    var expression = action.Body as MethodCallExpression;
        //    string methodName = string.Empty;
        //    if (expression != null)
        //    {
        //        methodName = expression.Method.Name;
        //    }

        //    var expression1 = action.Body as UnaryExpression;
        //    object[] inputParam = new object[expression.Arguments.Count];
        //    int i = 0;
        //    foreach (var arg in expression.Arguments)
        //    {
        //        var ue = arg as UnaryExpression;
        //        inputParam[i++] = (ue.Operand as ConstantExpression).Value;
        //    }
 
        //    Request request = new Request()
        //    {
        //        AssemblyName = "XY.His.Service",
        //        ClassName = "XY.His.Service.BS.UserService",
        //        MethodName = methodName,
        //        InputParam = inputParam
        //    };

        //    return Invoke(proxy, request);        
        //}

        //public static Response Invoke<T, TResult>(Expression<Func<T, TResult>> func)
        //    where T : IServiceBase
        //{      
        //    T proxy = GetProxy<XY.His.Contract.IServiceProvider>();

        //    //var expressionNode = func.ToExpressionNode();

        //    var expression = func.Body as MethodCallExpression;
        //    string methodName = string.Empty;
        //    if (expression != null)
        //    {
        //        methodName = expression.Method.Name;
        //    }
            
 
        //    object[] inputParam = new object[expression.Arguments.Count];
        //    int i = 0;
        //    foreach(var arg in expression.Arguments)
        //    {
        //        var ue = arg as UnaryExpression;
        //        inputParam[i++] = (ue.Operand as ConstantExpression).Value;
        //    }
        //    var memberExpression = func.Body as MemberExpression;
        //    Request request = new Request() 
        //    {
        //        AssemblyName = "XY.His.Service",
        //        ClassName = "XY.His.Service.BS.ItemService",
        //        MethodName = methodName,
        //        InputParam = inputParam
        //    };
        //    return Invoke(proxy, request);
        //}

        //public static Response Invoke<T, TResult>(Expression<Func<T, TResult>> func)
        //    where T : IServiceBase
        //{
        //    var proxy = GetProxy<XY.His.Contract.IServiceProvider>();

        //    var expression = func.Body as MethodCallExpression;
        //    string methodName = string.Empty;
        //    if (expression != null)
        //    {
        //        methodName = expression.Method.Name;
        //    }

        //    object[] inputParam = new object[expression.Arguments.Count];
        //    int i = 0;
        //    foreach (var arg in expression.Arguments)
        //    {
        //        var ue = arg as UnaryExpression;
        //        inputParam[i++] = (ue.Operand as ConstantExpression).Value;
        //    }
        //    var memberExpression = func.Body as MemberExpression;
        //    Request request = new Request()
        //    {
        //        AssemblyName = "XY.His.Service",
        //        ClassName = "XY.His.Service.BS.ItemService",
        //        MethodName = methodName,
        //        InputParam = inputParam
        //    };
            
        //    return proxy.Invoke2<T, TResult>(func.ToExpressionNode());
        //}


        public static Response ProcessRequest(Request request)
        {
            try
            {
                //获取代理实例
                XY.His.Contract.IServiceProvider serviceProvider = GetProxy<XY.His.Contract.IServiceProvider>();

                //序列化参数
                byte[] inputParam = Serializer.SerializeBinary(request.InputParam);

                //调用服务
                Response response = serviceProvider.Invoke(request.AssemblyName, request.ClassName, request.MethodName, inputParam);
                if (response.Status == ResponseStatus.OK)
                {
                    //反序列化结果
                    object[] results = Serializer.DeserializeBinary((byte[])response.Result);

                    //设置结果到响应
                    response.Result = results[0];
                }

                //返回服务处理响应
                return response;
            }
            catch (SoapException soe)
            {
                //TODO:
                return null;
            }
            catch (ThreadAbortException te)
            {
                //TODO:
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Execute Error:\n  Assembly={0}\n  Method={1}.{2}\n  {3}", request.AssemblyName, request.ClassName, request.MethodName, ex.Message));
            }
        }

        private static T GetProxy<T>()
            where T : IServiceBase
        {
            try
            {
                Proxy proxy = new Proxy();
                return proxy.GetContract<T>();
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("GetProxy<{0}> Exception: {1} \n{2}", typeof(T), GetErrMessage(ex, EnumExeptionType.Exception), ex.StackTrace);
                throw;
            }
        }

        private static Response ProcessRequest<T>(T proxy, Action<T> action)
             where T : IServiceBase
        {
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
            catch (System.ServiceModel.CommunicationException ce)
            {
                response.Message = GetErrMessage(ce, EnumExeptionType.CommunicationException);
            }
            catch (TimeoutException te)
            {
                response.Message = GetErrMessage(te, EnumExeptionType.TimeoutException);
            }
            catch (Exception ex)
            {
                response.Message = GetErrMessage(ex, EnumExeptionType.Exception);
            }
            finally
            {
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
            catch (System.ServiceModel.CommunicationException ce)
            {
                response.Message = GetErrMessage(ce, EnumExeptionType.CommunicationException);
            }
            catch (TimeoutException te)
            {
                response.Message = GetErrMessage(te, EnumExeptionType.TimeoutException);
            }
            catch (Exception ex)
            {
                response.Message = GetErrMessage(ex, EnumExeptionType.Exception);
            }
            finally
            {
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

        private static string GetErrMessage(Exception ex, EnumExeptionType exeptionType)
        {
            string errMessage = string.Empty;
            Exception innerException = ex.GetInnerException();
            if (innerException != null)
            {
                errMessage = string.Format("{0}: {1} \n{2}", exeptionType.ToString(), innerException.Message, ex.StackTrace);
            }

            return errMessage;
        }

        private enum EnumExeptionType
        {
            Exception = 0,
            TimeoutException = 1,
            CommunicationException = 2,
        }
    }
}
