using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INInvoiceDtlServiceUnitTest : TestBase
    {
        public INInvoiceDtlServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INInvoiceDtlService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 749861;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InInvoiceDtlDto dto = getByIdResponse.Result as InInvoiceDtlDto;
                Assert.Equal(ID, dto.ID);
            }
        }
    }
}
