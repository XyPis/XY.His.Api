using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INInvoiceServiceUnitTest : TestBase
    {
        public INInvoiceServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INInvoiceService";
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
                InInvoiceDto dto = getByIdResponse.Result as InInvoiceDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
