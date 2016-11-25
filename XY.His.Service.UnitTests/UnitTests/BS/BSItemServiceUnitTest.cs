using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 822144;

            var getByIdResponse = ServiceProxy.CallService<IBSItemService, BsItemDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                BsItemDto dto = getByIdResponse.Result as BsItemDto;
                Assert.Equal(ID, dto.ID);
            }
        }
    }
}
