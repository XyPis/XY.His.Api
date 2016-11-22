using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSGroupServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 28;

            var getByIdResponse = ServiceProxy.CallService<IBSGroupService, BsGroupDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsGroupDto dto = getByIdResponse.Result as BsGroupDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
