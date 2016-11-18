using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemItemServiceUnitTest : TestBase
    {        
        public BSItemItemServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemItemService";
        }

        [Fact]
        public void GetByItemId_TestMethod()
        {
            int ID = 817200;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemItemDto> dtos = getByIdResponse.Result as IList<BsItemItemDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
