using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INAdviceTempServiceUnitTest : TestBase
    {
        public INAdviceTempServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INAdviceTempService";
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
                InAdviceTempDto dto = getByIdResponse.Result as InAdviceTempDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
