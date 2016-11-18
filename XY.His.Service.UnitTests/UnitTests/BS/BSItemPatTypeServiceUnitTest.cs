using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemPatTypeServiceUnitTest : TestBase
    {        
        public BSItemPatTypeServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemPatTypeService";
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
                IList<BsItemPatTypeDto> dtos = getByIdResponse.Result as IList<BsItemPatTypeDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
