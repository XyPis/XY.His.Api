using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemUnitServiceUnitTest : TestBase
    {        
        public BSItemUnitServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemUnitService";
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
                IList<BsItemUnitDto> dtos = getByIdResponse.Result as IList<BsItemUnitDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
