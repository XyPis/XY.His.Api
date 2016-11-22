using System;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.Gbl;
using XY.His.Contract.Service.Gbl;

namespace XY.His.Service.UnitTests.Gbl
{
    public class GblSystemServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;

            var getByIdResponse = ServiceProxy.CallService<IGblSystemService, GblSystemDto>(x => x.GetById(ID));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                GblSystemDto dto = getByIdResponse.Result as GblSystemDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
