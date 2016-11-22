using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.OP;
using XY.His.Contract.Service.OP;

namespace XY.His.Service.UnitTests.OP
{    
    public class PSExecuteServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IPSExecuteService, PsExecuteDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                PsExecuteDto dto = getByIdResponse.Result as PsExecuteDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
