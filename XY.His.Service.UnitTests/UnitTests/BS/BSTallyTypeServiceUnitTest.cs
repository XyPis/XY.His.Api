using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSTallyTypeServiceUnitTest : TestBase
    {                 
        [Fact]
        [Trait("BS", "BSTallyTypeService")]
        public void GetById_TestMethod()
        {
            int ID = 12;

            var getByIdResponse = ServiceProxy.CallService<IBSTallyTypeService, BsTallyTypeDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                BsTallyTypeDto dto = getByIdResponse.Result as BsTallyTypeDto;
                Assert.Equal(ID, dto.ID);
            }
        }

        [Fact]
        [Trait("BS", "BSTallyTypeService")]
        public void Add_TestMethod()
        {
            BsTallyTypeDto tallyTypeDto = new BsTallyTypeDto() 
            {
                Code = "ABC",
                Name = "test",
                TallyGroupId = 201,
                PyCode = "XXX",
                WbCode = "YYY",
                OrderBy = 3,
                IsActive = true,
                F4 = "Customer",
            };

            var getByIdResponse = ServiceProxy.CallService<IBSTallyTypeService, BsTallyTypeDto>(x => x.Add(tallyTypeDto));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
        }      
    }
}
