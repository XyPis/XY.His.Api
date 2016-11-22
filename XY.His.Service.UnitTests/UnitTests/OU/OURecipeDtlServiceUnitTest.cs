using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.OU;
using XY.His.Contract.Service.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OURecipeDtlServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IOURecipeDtlService, OuRecipeDtlDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                OuRecipeDtlDto dto = getByIdResponse.Result as OuRecipeDtlDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
