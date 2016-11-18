using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.RM;

namespace XY.His.Service.UnitTests.RM
{    
    public class RMZyOutDtlServiceUnitTest : TestBase
    {
        public RMZyOutDtlServiceUnitTest()
        {
            ClassName = "XY.His.Service.RM.RMZyOutDtlService";
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
                RmZyOutDtlDto dto = getByIdResponse.Result as RmZyOutDtlDto;
                Assert.Equal(ID, dto.ID);
            }            
        }
    }
}
