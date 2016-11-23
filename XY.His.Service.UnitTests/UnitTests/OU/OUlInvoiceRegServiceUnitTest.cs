using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.OU;
using XY.His.Contract.Service.OU;

namespace XY.His.Service.UnitTests.OU
{
    public class OUlInvoiceRegServiceUnitTest : TestBase
    {
        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;
            
            var getByIdResponse = ServiceProxy.CallService<IOUlInvoiceRegService, OulInvoiceRegDto>(x => x.GetById(ID));
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
            ExpressionNode expressionNode = query.ToExpressionNode();
            
            var getByIdResponse = ServiceProxy.CallService<IOUlInvoiceRegService, IEnumerable<OulInvoiceRegDto>>(x => x.GetBy(expressionNode));
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
            ExpressionNode expressionNode = query.ToExpressionNode();

            var getByIdResponse = ServiceProxy.CallService<IOUlInvoiceRegService, int>(x => x.DeleteBy(expressionNode));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
        }       
    }
}
