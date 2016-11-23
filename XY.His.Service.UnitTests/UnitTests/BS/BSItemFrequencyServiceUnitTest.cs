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
    public class BSItemFrequencyServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 825796;
            Expression<Func<BsItemFrequencyDto, bool>> query = (x => x.ItemId == itemID);
            ExpressionNode expressionNode = query.ToExpressionNode();
            
            var getByIdResponse = ServiceProxy.CallService<IBSItemFrequencyService, IEnumerable<BsItemFrequencyDto>>(x => x.GetBy(expressionNode));

            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemFrequencyDto> dtos = getByIdResponse.Result as IList<BsItemFrequencyDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
