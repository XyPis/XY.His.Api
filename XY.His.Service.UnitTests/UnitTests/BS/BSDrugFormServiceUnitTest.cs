using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSDrugFormServiceUnitTest : TestBase
    {
        [Fact]
        [Trait("BS", "BSDrugFormService")]
        public void GetById_TestMethod()
        {
            int ID = 12;

            var getByIdResponse = ServiceProxy.CallService<IBSDrugFormService, BsDrugFormDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsDrugFormDto dto = getByIdResponse.Result as BsDrugFormDto;
                Assert.Equal(ID, dto.ID);
            }
        }      
    }
}
