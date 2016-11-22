using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.IN;
using XY.His.Contract.Service.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INPatFeesListServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 183711;

            var getByIdResponse = ServiceProxy.CallService<IINPatFeesListService, InPatFeesListDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InPatFeesListDto dto = getByIdResponse.Result as InPatFeesListDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
