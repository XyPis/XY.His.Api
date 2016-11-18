using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemLocationServiceUnitTest : TestBase
    {        
        public BSItemLocationServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemLocationService";
        }

        [Fact]
        public void GetByItemId_TestMethod()
        {
            int ID = 304822;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemLocationDto> dtos = getByIdResponse.Result as IList<BsItemLocationDto>;
                Assert.True(dtos.Count > 0);
            }
        }
    }
}
