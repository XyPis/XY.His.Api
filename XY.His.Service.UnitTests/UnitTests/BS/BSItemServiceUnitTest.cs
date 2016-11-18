using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemServiceUnitTest : TestBase
    {        
        public BSItemServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 822144;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                BsItemDto dto = getByIdResponse.Result as BsItemDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
