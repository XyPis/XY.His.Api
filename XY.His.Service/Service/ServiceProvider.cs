using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.ServiceModel;
using XY.His.Contract.Message;
using XY.His.Utils;

namespace XY.His.Service
{
    public class ServiceProvider : XY.His.Contract.IServiceProvider
    {
        public Response Invoke(string assemblyName, string className, string methodName, params byte[] inputParam)
        {
            Response response = new Response();

            try
            {
                object[] args = Serializer.DeserializeBinary(inputParam);

                object result = InvokeHelper.InvokeMethod(assemblyName, className, methodName, args);

                result = Serializer.SerializeBinary(new object[] { result });

                response.Result = result;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = ResponseStatus.Error;
                response.Result = null;
            }

            return response;
        }

        //public Response Invoke2<TContract, TResult>(ExpressionNode expressionNode)
        //{
        //    Response response = new Response();
            
        //    TContract contract = XY.His.Utils.Unity.IoC.Resolve<TContract>();
        //    var expression = expressionNode.ToExpression<TContract>();
            
        //    //Process<TContract, TResult>(contract);
            
        //    return response;
        //}

        //Response Process<TContract, TResult>(TContract contract, Func<TContract, TResult> func)
        //{
        //    Response response = new Response()
        //    {
        //        Result = default(TResult)
        //    };
            
        //    response.Result = func(contract);

        //    return response;
        //}
    }
}
