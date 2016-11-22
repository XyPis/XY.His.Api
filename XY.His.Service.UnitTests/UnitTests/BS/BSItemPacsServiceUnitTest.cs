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
    public class BSItemPacsServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 188;
            Expression<Func<BsItemPacsDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSItemPacsService, IEnumerable<BsItemPacsDto>> expression = (x => x.Get(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemPacsService, IEnumerable<BsItemPacsDto>>(expression);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemPacsDto> dtos = getByIdResponse.Result as IList<BsItemPacsDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
