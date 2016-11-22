using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.Gbl;
using XY.His.Contract.Service.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblRoleServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IGblRoleService, GblRoleDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                GblRoleDto dto = getByIdResponse.Result as GblRoleDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
