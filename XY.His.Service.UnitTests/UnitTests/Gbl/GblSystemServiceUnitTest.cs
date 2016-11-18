using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblSystemServiceUnitTest : TestBase
    {
        public GblSystemServiceUnitTest()
        {
            ClassName = "XY.His.Service.Gbl.GblSystemService";
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
                GblSystemDto dto = getByIdResponse.Result as GblSystemDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
