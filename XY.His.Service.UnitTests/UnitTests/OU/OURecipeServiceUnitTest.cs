using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OURecipeServiceUnitTest : TestBase
    {
        public OURecipeServiceUnitTest()
        {
            ClassName = "XY.His.Service.OU.OURecipeService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                OuRecipeDto dto = getByIdResponse.Result as OuRecipeDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
