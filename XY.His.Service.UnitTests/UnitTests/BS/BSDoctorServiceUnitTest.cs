using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSDoctorServiceUnitTest : TestBase
    {
        public BSDoctorServiceUnitTest()
        {            
            ClassName = "XY.His.Service.BS.BSDoctorService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 188;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                BsDoctorDto dto = getByIdResponse.Result as BsDoctorDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
