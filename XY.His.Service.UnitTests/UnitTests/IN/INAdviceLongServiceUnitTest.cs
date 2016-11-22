using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.IN;
using XY.His.Contract.Service.IN;

namespace XY.His.Service.UnitTests.IN
{    
    public class INAdviceLongServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IINAdviceLongService, InAdviceLongDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InAdviceLongDto dto = getByIdResponse.Result as InAdviceLongDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
