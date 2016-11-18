using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INInvoiceDtlDumpServiceUnitTest : TestBase
    {
        public INInvoiceDtlDumpServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INInvoiceDtlDumpService";
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
                InInvoiceDtlDumpDto dto = getByIdResponse.Result as InInvoiceDtlDumpDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
