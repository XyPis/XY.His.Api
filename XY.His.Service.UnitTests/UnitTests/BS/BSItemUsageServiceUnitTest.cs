using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemUsageServiceUnitTest : TestBase
    {        
        public BSItemUsageServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemUsageService";
        }

        [Fact]
        public void GetByItemId_TestMethod()
        {
            int ID = 825795;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemUsageDto> dtos = getByIdResponse.Result as IList<BsItemUsageDto>;
                Assert.True(dtos.Count > 0);
            }
        }
    }
}
