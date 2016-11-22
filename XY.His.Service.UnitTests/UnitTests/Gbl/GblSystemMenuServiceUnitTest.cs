using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.Gbl;
using XY.His.Contract.Service.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblSystemMenuServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;
            
            var getByIdResponse = ServiceProxy.CallService<IGblSystemMenuService, GblSystemMenuDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                GblSystemMenuDto dto = getByIdResponse.Result as GblSystemMenuDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
