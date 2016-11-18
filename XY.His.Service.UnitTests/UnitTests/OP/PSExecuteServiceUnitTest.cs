using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OP;

namespace XY.His.Service.UnitTests.OP
{    
    public class PSExecuteServiceUnitTest : TestBase
    {
        public PSExecuteServiceUnitTest()
        {
            ClassName = "XY.His.Service.OP.PSExecuteService";
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
                PsExecuteDto dto = getByIdResponse.Result as PsExecuteDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
