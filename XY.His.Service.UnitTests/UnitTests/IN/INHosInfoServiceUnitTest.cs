using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INHosInfoServiceUnitTest : TestBase
    {
        public INHosInfoServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INHosInfoService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 7622;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                InHosInfoDto dto = getByIdResponse.Result as InHosInfoDto;
                Assert.Equal(ID, dto.ID);
            }            
        }
    }
}
