using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSLocationServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 1576;

            var getByIdResponse = ServiceProxy.CallService<IBSLocationService, BsLocationDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsLocationDto dto = getByIdResponse.Result as BsLocationDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
