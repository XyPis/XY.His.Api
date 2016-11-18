using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSGroupSub2ServiceUnitTest : TestBase
    {        
        public BSGroupSub2ServiceUnitTest()
        {
            ClassName = "XY.His.Service.BS.BSGroupSub2Service";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 12;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsGroupSub2Dto dto = getByIdResponse.Result as BsGroupSub2Dto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
