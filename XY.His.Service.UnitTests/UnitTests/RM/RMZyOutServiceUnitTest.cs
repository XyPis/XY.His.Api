using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.RM;

namespace XY.His.Service.UnitTests.RM
{    
    public class RMZyOutServiceUnitTest : TestBase
    {
        public RMZyOutServiceUnitTest()
        {
            ClassName = "XY.His.Service.RM.RMZyOutService";
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
                RmZyOutDto dto = getByIdResponse.Result as RmZyOutDto;
                Assert.Equal(ID, dto.ID);
            }            
        }
    }
}
