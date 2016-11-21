using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.OU;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;

namespace XY.His.Service.UnitTests.OU
{
    public class OUlInvoiceRegServiceUnitTest : TestBase
    {
        public OUlInvoiceRegServiceUnitTest()
        {
            ClassName = "XY.His.Service.OU.OUlInvoiceRegService";
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
                OulInvoiceRegDto dto = getByIdResponse.Result as OulInvoiceRegDto;
                Assert.Equal(ID, dto.ID);
            }
        }        

        [Fact]
        public void GetByExpressionNode_TestMethod()
        {
            int mzRegId = 12963;
            Expression<Func<OulInvoiceRegDto, bool>> query = (x => x.MzRegId == mzRegId);
            Serialize.Linq.Nodes.ExpressionNode expressionNode = query.ToExpressionNode();

            var getByIdRequest = BuildRequest("Get", new object[] { expressionNode });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                IList<OulInvoiceRegDto> dtos = getByIdResponse.Result as IList<OulInvoiceRegDto>;
                Assert.NotNull(dtos);
            }
        }

        [Fact]
        public void DeleteByExpressionNode_TestMethod()
        {
            int mzRegId = 12963;
            Expression<Func<OulInvoiceRegDto, bool>> query = (x => x.MzRegId == mzRegId);
            Serialize.Linq.Nodes.ExpressionNode expressionNode = query.ToExpressionNode();

            var getByIdRequest = BuildRequest("Delete", new object[] { expressionNode });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
        }       
    }
}
