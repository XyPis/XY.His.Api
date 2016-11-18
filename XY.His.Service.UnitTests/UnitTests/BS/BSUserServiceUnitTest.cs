using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSUserServiceUnitTest : TestBase
    {
        public BSUserServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSUserService";
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
                BsUserDto dto = getByIdResponse.Result as BsUserDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
