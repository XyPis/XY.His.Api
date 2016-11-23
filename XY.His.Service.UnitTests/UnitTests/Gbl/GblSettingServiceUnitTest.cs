using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.Gbl;
using XY.His.Contract.Service.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblSettingServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 15;

            var getByIdResponse = ServiceProxy.CallService<IGblSettingService, GblSettingDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                GblSettingDto dto = getByIdResponse.Result as GblSettingDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
