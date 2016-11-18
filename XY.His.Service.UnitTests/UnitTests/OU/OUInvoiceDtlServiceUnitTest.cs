using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OUInvoiceDtlServiceUnitTest : TestBase
    {
        public OUInvoiceDtlServiceUnitTest()
        {
            ClassName = "XY.His.Service.OU.OUInvoiceDtlService";
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
                OuInvoiceDtlDto dto = getByIdResponse.Result as OuInvoiceDtlDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
