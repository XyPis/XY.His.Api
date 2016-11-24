using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSDoctorServiceUnitTest : TestBase
    {
        [Fact]
        [Trait("BS", "BSDoctorService")]
        public void GetById_TestMethod()
        {
            int ID = 188;
            
            var getByIdResponse = ServiceProxy.CallService<IBSDoctorService, BsDoctorDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                BsDoctorDto dto = getByIdResponse.Result as BsDoctorDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
