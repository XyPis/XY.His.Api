using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSLimitDocLevServiceUnitTest : TestBase
    {        
        public BSLimitDocLevServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSLimitDocLevService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 12;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsLimitDocLevDto dto = getByIdResponse.Result as BsLimitDocLevDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
