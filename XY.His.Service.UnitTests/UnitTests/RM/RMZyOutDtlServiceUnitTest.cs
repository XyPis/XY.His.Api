using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.RM;
using XY.His.Contract.Service.RM;

namespace XY.His.Service.UnitTests.RM
{    
    public class RMZyOutDtlServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {            
            int ID = 7622;

            var getByIdResponse = ServiceProxy.CallService<IRMZyOutService, RmZyOutDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                RmZyOutDtlDto dto = getByIdResponse.Result as RmZyOutDtlDto;
                Assert.Equal(ID, dto.ID);
            }            
        }
    }
}
