using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.IN;
using XY.His.Contract.Service.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INAdviceAuthDtlServiceUnitTest : TestBase
    {

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;
            
            var getByIdResponse = ServiceProxy.CallService<IINAdviceAuthDtlService, InAdviceAuthDtlDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InAdviceAuthDtlDto dto = getByIdResponse.Result as InAdviceAuthDtlDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
