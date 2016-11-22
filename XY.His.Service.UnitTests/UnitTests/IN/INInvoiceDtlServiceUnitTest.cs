using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.IN;
using XY.His.Contract.Service.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INInvoiceDtlServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 749861;

            var getByIdResponse = ServiceProxy.CallService<IINInvoiceDtlService, InInvoiceDtlDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InInvoiceDtlDto dto = getByIdResponse.Result as InInvoiceDtlDto;
                Assert.Equal(ID, dto.ID);
            }
        }
    }
}
