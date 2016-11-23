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
    public class BSItemItemServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId1_TestMethod()
        {
            int itemID = 817200;

            Expression<Func<BsItemItemDto, bool>> query = (x => x.ItemId1 == itemID);
            Func<IBSItemItemService, IEnumerable<BsItemItemDto>> expression = (x => x.GetBy(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemItemService, IEnumerable<BsItemItemDto>>(expression);
           
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemItemDto> dtos = getByIdResponse.Result as IList<BsItemItemDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
