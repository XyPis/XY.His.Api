using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSRoomServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 39;

            var getByIdResponse = ServiceProxy.CallService<IBSRoomService, BsRoomDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsRoomDto dto = getByIdResponse.Result as BsRoomDto;
                Assert.Equal(ID, dto.ID);
            }            
        }
    }
}
