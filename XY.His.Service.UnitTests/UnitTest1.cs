using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Serialize.Linq.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XY.His;
using XY.His.Contract.Message;
 
using Serialize.Linq.Nodes;
using XY.His.Contract.Service.BS;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Wcf.UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        private const string AssemblyName = "XY.His.Service";

        [TestMethod]
        public void TestMethod1()
        {
            var getAllItemsRequest = new Request
            {
                AssemblyName = AssemblyName,
                ClassName = "XY.His.Service.BS.ItemService",
                MethodName = "GetAll"
            };
            var getAllItemsResponse = ServiceWrapper.ProcessRequest(getAllItemsRequest);
            Assert.IsTrue(getAllItemsResponse.Status == ResponseStatus.OK);
            if (getAllItemsResponse.Status == ResponseStatus.OK)
            {
                IEnumerable<BsItemDto> result = getAllItemsResponse.Result as IEnumerable<BsItemDto>;
                
            }
            
            var getAllSysParamsRequest = new Request
            {
                AssemblyName = AssemblyName,
                ClassName = "XY.His.Service.Gbl.SysParamService",
                MethodName = "GetAll"
            };
            var getAllSysParamsResponse = ServiceWrapper.ProcessRequest(getAllSysParamsRequest);
            Assert.IsTrue(getAllSysParamsResponse.Status == ResponseStatus.OK);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // var request = new Request
            //{
            //    AssemblyName = "XY.His.Service",
            //    ClassName = "XY.His.Service.BS.ItemService",
            //    MethodName = "GetAll"
            //};
            // var response = ServiceWrapper.Invoke<IUserService, dynamic>(x => x.GetAll());
            //Assert.IsTrue(response.Status == ResponseStatus.OK);

        }


        public class User
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }

        public class ClientProxy
        {
            public static Response Invoke<T, TResult>(Expression<Func<T, TResult>> func)
                where T : XY.His.Contract.Service.IServiceBase
            {
                var proxy = GetProxy<XY.His.Contract.IServiceProvider>();

                var expression = func.Body as MethodCallExpression;
                string methodName = string.Empty;
                if (expression != null)
                {
                    methodName = expression.Method.Name;
                }

                object[] inputParam = new object[expression.Arguments.Count];
                int i = 0;
                foreach (var arg in expression.Arguments)
                {
                    var ue = arg as UnaryExpression;
                    inputParam[i++] = (ue.Operand as ConstantExpression).Value;
                }
                var memberExpression = func.Body as MemberExpression;
                Request request = new Request()
                {
                    AssemblyName = "XY.His.Service",
                    ClassName = "XY.His.Service.BS.ItemService",
                    MethodName = methodName,
                    InputParam = inputParam
                };

                return ServiceWrapper.ProcessRequest(request);
            }

            private static T GetProxy<T>()            
                where T : XY.His.Contract.Service.IServiceBase
            {
                try
                {
                    Proxy proxy = new Proxy();
                    return proxy.GetContract<T>();
                }
                catch (Exception ex)
                {
                    //Log.ErrorFormat("GetProxy<{0}> Exception: {1} \n{2}", typeof(T), GetErrMessage(ex, EnumExeptionType.Exception), ex.StackTrace);
                    throw;
                }
            }
        }
    }
}
