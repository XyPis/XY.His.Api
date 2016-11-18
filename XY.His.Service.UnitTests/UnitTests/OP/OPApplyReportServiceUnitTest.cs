using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OP;

namespace XY.His.Service.UnitTests.OP
{    
    public class PSApplyReportServiceUnitTest : TestBase
    {
        public PSApplyReportServiceUnitTest()
        {
            ClassName = "XY.His.Service.OP.PSApplyReportService";
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
                PsApplyReportDto dto = getByIdResponse.Result as PsApplyReportDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
