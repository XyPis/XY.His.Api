using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemNameMultiServiceUnitTest : TestBase
    {        
        public BSItemNameMultiServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemNameMultiService";
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
                IList<BsItemNameMultiDto> dtos = getByIdResponse.Result as IList<BsItemNameMultiDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
