using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemAttachServiceUnitTest : TestBase
    {        
        public BSItemAttachServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemAttachService";
        }

        [Fact]
        public void GetByItemId_TestMethod()
        {
            int ID = 188;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                IList<BsItemAttachDto> dtos = getByIdResponse.Result as IList<BsItemAttachDto>;
                Assert.NotNull(dtos);
            }
        }      
    }
}
