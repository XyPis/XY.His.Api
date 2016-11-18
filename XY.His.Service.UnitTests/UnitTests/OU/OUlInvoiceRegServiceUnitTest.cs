using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OUlInvoiceRegServiceUnitTest : TestBase
    {
        public OUlInvoiceRegServiceUnitTest()
        {
            ClassName = "XY.His.Service.OU.OUlInvoiceRegService";
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
                OulInvoiceRegDto dto = getByIdResponse.Result as OulInvoiceRegDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
