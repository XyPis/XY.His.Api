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
    public class BSItemUnitServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 188;
            Expression<Func<BsItemUnitDto, bool>> query = (x => x.ItemId == itemID);
            var getByIdResponse = ServiceProxy.CallService<IBSItemUnitService, IEnumerable<BsItemUnitDto>>(x => x.GetBy(query.ToExpressionNode()));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemUnitDto> dtos = getByIdResponse.Result as IList<BsItemUnitDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
