using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemYbServiceUnitTest : TestBase
    {        
        public BSItemYbServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemYbService";
        }

        [Fact]
        public void GetByItemId_TestMethod()
        {
            int ID = 822156;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemYbDto> dtos = getByIdResponse.Result as IList<BsItemYbDto>;
                Assert.True(dtos.Count > 0);
            }
        }
    }
}
