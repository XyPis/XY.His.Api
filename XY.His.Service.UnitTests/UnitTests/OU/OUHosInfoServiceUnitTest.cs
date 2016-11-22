using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.OU;
using XY.His.Contract.Service.OU;

namespace XY.His.Service.UnitTests.OU
{    
    public class OUHosInfoServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IOUHosInfoService, OuHosInfoDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                OuHosInfoDto dto = getByIdResponse.Result as OuHosInfoDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
