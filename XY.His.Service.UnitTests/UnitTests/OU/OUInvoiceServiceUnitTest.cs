using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.OU;
using XY.His.Contract.Service.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OUInvoiceServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IOUInvoiceService, OuInvoiceDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                OuInvoiceDto dto = getByIdResponse.Result as OuInvoiceDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
