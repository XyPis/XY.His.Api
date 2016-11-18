using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using XY.His.Proxy;
using XY.His.Contract.Service.Gbl;
using XY.His.Contract.Message.Gbl;
using XY.His.Contract.Service.BS;
using XY.His.Contract.Message.BS;
using System.ServiceModel;
using XY.His.Contract;
using XY.His.Service.BS;
using System.ServiceModel.Channels;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var getAllResponse = ServiceWrapper.Invoke<IUserService, dynamic>(x => x.GetAll());
            Assert.IsTrue(getAllResponse.Status == ResponseStatus.OK);


            var response = ServiceWrapper.Invoke<ISysParamService, dynamic>(x => x.GetAll());
            Assert.IsTrue(response.Status == ResponseStatus.OK);

            var response1 = ServiceWrapper.Invoke<IItemService, dynamic>(x => x.GetAll());
            Assert.IsTrue(response1.Status == ResponseStatus.OK);
            
        }

        
        [TestMethod]
        public void TestGetAll()
        {
            //Uri uri = new Uri("net.tcp://localhost:8765/vwxyzh/helloworld/");
            Uri uri = new Uri("http://localhost:50410/LoginUserService.svc");

            typeof(UserService).RunWcfService(() =>
            {
                uri.InvokeWcfClient<IUserService>(new NetTcpBinding(),
                client =>
                {
                    var response =  client.GetAll();
                });
        });
        }
    }

    public static class aa
    {
        public static void RunWcfService(this Type type, Action action)
        {            
            var host = new ServiceHost(type);
            try
            {
                host.Open();
                action();
            }
            finally
            {
                if (host.State == CommunicationState.Faulted)
                    host.Abort();
                else
                    host.Close();
            }
        }

        public static void InvokeWcfClient<TChannel>(this Uri uri, Binding binding, Action<TChannel> action)
            where TChannel : class
        {
            TChannel client = ChannelFactory<TChannel>.CreateChannel(
                binding, new EndpointAddress(uri));
            var co = (ICommunicationObject)client;
            try
            {
                co.Open();
                action(client);
            }
            finally
            {
                if (co.State == CommunicationState.Faulted)
                    co.Abort();
                else
                    co.Close();
            }
        }
    }

}
