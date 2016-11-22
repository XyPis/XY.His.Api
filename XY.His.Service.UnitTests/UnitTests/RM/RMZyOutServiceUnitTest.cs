using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.RM;
using XY.His.Contract.Service.RM;

namespace XY.His.Service.UnitTests.RM
{    
    public class RMZyOutServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 12;

            var getByIdResponse = ServiceProxy.CallService<IRMZyOutService, RmZyOutDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                RmZyOutDto dto = getByIdResponse.Result as RmZyOutDto;
                Assert.Equal(ID, dto.ID);
            }
        }
    }
}
