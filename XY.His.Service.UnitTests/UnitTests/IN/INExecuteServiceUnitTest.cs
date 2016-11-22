using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.IN;
using XY.His.Contract.Service.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INExecuteServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IINExecuteService, InExecuteDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InExecuteDto dto = getByIdResponse.Result as InExecuteDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
