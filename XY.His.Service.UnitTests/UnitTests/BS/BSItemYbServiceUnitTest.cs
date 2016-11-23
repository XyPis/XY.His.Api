using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using System.Linq.Expressions;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemYbServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemId = 822156;

            Expression<Func<BsItemYbDto, bool>> query = (x => x.ItemId == itemId);
            ExpressionNode expressionNode = query.ToExpressionNode();
            var getByIdResponse = ServiceProxy.CallService<IBSItemYbService, IEnumerable<BsItemYbDto>>(x => x.GetBy(expressionNode));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemYbDto> dtos = getByIdResponse.Result as IList<BsItemYbDto>;
                Assert.True(dtos.Count > 0);
            }
        }
    }
}
