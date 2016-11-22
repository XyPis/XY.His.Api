using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;
using Serialize.Linq.Extensions;
using Serialize.Linq.Nodes;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemNameMultiServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 817200;
            Expression<Func<BsItemNameMultiDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSItemNameMultiService, IEnumerable<BsItemNameMultiDto>> expression = (x => x.Get(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemNameMultiService, IEnumerable<BsItemNameMultiDto>>(expression);
            
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemNameMultiDto> dtos = getByIdResponse.Result as IList<BsItemNameMultiDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
