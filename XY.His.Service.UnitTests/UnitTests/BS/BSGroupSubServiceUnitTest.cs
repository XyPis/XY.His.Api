using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSGroupSubServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 12;

            var getByIdResponse = ServiceProxy.CallService<IBSGroupService, BsGroupDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsGroupSubDto dto = getByIdResponse.Result as BsGroupSubDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
