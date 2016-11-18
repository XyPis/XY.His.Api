using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblSystemMenuServiceUnitTest : TestBase
    {
        public GblSystemMenuServiceUnitTest()
        {
            ClassName = "XY.His.Service.Gbl.GblSystemMenuService";
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
                GblSystemMenuDto dto = getByIdResponse.Result as GblSystemMenuDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
