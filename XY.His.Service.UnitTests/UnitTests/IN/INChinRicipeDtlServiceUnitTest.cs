using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{    
    public class INChinRicipeDtlServiceUnitTest : TestBase
    {
        public INChinRicipeDtlServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INChinRicipeDtlService";
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
                InChinRicipeDtlDto dto = getByIdResponse.Result as InChinRicipeDtlDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
