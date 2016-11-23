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
    public class BSItemAttachServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId1_TestMethod()
        {
            int itemID = 188;
            Expression<Func<BsItemAttachDto, bool>> query = (x => x.ItemId1 == itemID);
            Func<IBSItemAttachService, IEnumerable<BsItemAttachDto>> expression = (x => x.GetBy(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemAttachService, IEnumerable<BsItemAttachDto>>(expression);
          
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                IList<BsItemAttachDto> dtos = getByIdResponse.Result as IList<BsItemAttachDto>;
                Assert.NotNull(dtos);
            }
        }      
    }
}
