using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.IN;
using XY.His.Contract.Service.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INHosInfoServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 7622;

            var getByIdResponse = ServiceProxy.CallService<IINHosInfoService, InHosInfoDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                InHosInfoDto dto = getByIdResponse.Result as InHosInfoDto;
                Assert.Equal(ID, dto.ID);
            }            
        }
    }
}
