using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemFrequencyServiceUnitTest : TestBase
    {        
        public BSItemFrequencyServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemFrequencyService";
        }

        [Fact]
        public void GetByItemId_TestMethod()
        {
            int ID = 825796;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemFrequencyDto> dtos = getByIdResponse.Result as IList<BsItemFrequencyDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
