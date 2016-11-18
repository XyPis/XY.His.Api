using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSLocPatTypeServiceUnitTest : TestBase
    {
        public BSLocPatTypeServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSLocPatTypeService";
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
                BsPatTypeDto dto = getByIdResponse.Result as BsPatTypeDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
