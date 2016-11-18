using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblRoleServiceUnitTest : TestBase
    {
        public GblRoleServiceUnitTest()
        {
            ClassName = "XY.His.Service.Gbl.GblRoleService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                GblRoleDto dto = getByIdResponse.Result as GblRoleDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
