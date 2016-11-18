using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSRoomServiceUnitTest : TestBase
    {
        public BSRoomServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSRoomService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 39;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsRoomDto dto = getByIdResponse.Result as BsRoomDto;
                Assert.Equal(ID, dto.ID);
            }            
        }
    }
}
