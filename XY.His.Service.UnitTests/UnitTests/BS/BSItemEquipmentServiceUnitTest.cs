using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemEquipmentServiceUnitTest : TestBase
    {        
        public BSItemEquipmentServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSItemEquipmentService";
        }

        [Fact]
        public void GetById_TestMethod()
        {            
            int ID = 188;
            var getByIdRequest = BuildRequest("GetByItemId", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemEquipmentDto> dtos = getByIdResponse.Result as IList<BsItemEquipmentDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
