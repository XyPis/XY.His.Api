using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSUnitRatioServiceUnitTest : TestBase
    {
        public BSUnitRatioServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSUnitRatioService";
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
                IList<BsUnitRatioDto> dtos = getByIdResponse.Result as IList<BsUnitRatioDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
