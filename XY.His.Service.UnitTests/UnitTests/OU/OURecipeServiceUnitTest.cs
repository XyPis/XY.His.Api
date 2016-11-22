using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.OU;
using XY.His.Contract.Service.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OURecipeServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IOURecipeService, OuRecipeDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                OuRecipeDto dto = getByIdResponse.Result as OuRecipeDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
