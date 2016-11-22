using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSUsageServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 12;
            
            var getByIdResponse = ServiceProxy.CallService<IBSUsageService, BsUsageDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsUsageDto dto = getByIdResponse.Result as BsUsageDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
