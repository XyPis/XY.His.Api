using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OURecipeDtlServiceUnitTest : TestBase
    {
        public OURecipeDtlServiceUnitTest()
        {
            ClassName = "XY.His.Service.OU.OURecipeDtlService";
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
                OuRecipeDtlDto dto = getByIdResponse.Result as OuRecipeDtlDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
