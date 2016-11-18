using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSLocationServiceUnitTest : TestBase
    {
        public BSLocationServiceUnitTest()
        {            
            ClassName = "XY.His.Service.BS.BSLocationService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 1576;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsLocationDto dto = getByIdResponse.Result as BsLocationDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
