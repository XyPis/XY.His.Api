using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.RM;
using XY.His.Contract.Service.RM;

namespace XY.His.Service.UnitTests.RM
{    
    public class RMStoreServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 1023;

            var getByIdResponse = ServiceProxy.CallService<IRMStoreService, RmStoreDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                RmStoreDto dto = getByIdResponse.Result as RmStoreDto;
                Assert.Equal(ID, dto.ID);
            }
        }
    }
}
