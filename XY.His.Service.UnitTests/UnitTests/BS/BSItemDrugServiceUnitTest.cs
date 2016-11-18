using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemDrugServiceUnitTest : TestBase
    {        
        public BSItemDrugServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemDrugService";
        }

        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemId = 826209;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { itemId });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            //Assert.NotNull(getByIdResponse.Result);
            if (getByIdResponse.Result != null)
            {
                IList<BsItemDrugDto> dtos = getByIdResponse.Result as IList<BsItemDrugDto>;
                Assert.NotNull(dtos);
            }
        }      
    }
}
