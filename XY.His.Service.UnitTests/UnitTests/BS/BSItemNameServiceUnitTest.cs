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
    public class BSItemNameServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 817200;
            Expression<Func<BsItemNameDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSItemNameService, IEnumerable<BsItemNameDto>> expression = (x => x.GetBy(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemNameService, IEnumerable<BsItemNameDto>>(expression);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemNameDto> dtos = getByIdResponse.Result as IList<BsItemNameDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
