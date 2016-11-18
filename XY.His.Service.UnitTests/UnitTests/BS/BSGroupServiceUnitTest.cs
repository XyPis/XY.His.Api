using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSGroupServiceUnitTest : TestBase
    {        
        public BSGroupServiceUnitTest()
        {            
            ClassName = "XY.His.Service.BS.BSGroupService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 28;         
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsGroupDto dto = getByIdResponse.Result as BsGroupDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
