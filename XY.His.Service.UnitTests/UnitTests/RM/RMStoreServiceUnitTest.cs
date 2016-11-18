using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.RM;

namespace XY.His.Service.UnitTests.RM
{    
    public class RMStoreServiceUnitTest : TestBase
    {
        public RMStoreServiceUnitTest()
        {
            ClassName = "XY.His.Service.RM.RMStoreService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 1023;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                RmStoreDto dto = getByIdResponse.Result as RmStoreDto;
                Assert.Equal(ID, dto.ID);
            }
        }
    }
}
