using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{
    public class INPatFeesListServiceUnitTest : TestBase
    {
        public INPatFeesListServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INPatFeesListService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 183711;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InPatFeesListDto dto = getByIdResponse.Result as InPatFeesListDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
