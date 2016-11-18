using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblSettingServiceUnitTest : TestBase
    {
        public GblSettingServiceUnitTest()
        {
            ClassName = "XY.His.Service.Gbl.GblSettingService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                GblSettingDto dto = getByIdResponse.Result as GblSettingDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
