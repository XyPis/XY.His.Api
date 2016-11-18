using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OU;

namespace XY.His.Service.UnitTests.OU
{    
    public class OUClincDiagServiceUnitTest : TestBase
    {
        public OUClincDiagServiceUnitTest()
        {
            ClassName = "XY.His.Service.OU.OUClincDiagService";
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
                OuClincDiagDto dto = getByIdResponse.Result as OuClincDiagDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
