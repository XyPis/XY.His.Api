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
    public class BSItemUsageServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 825795;
            Expression<Func<BsItemUsageDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSItemUsageService, IEnumerable<BsItemUsageDto>> expression = (x => x.Get(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemUsageService, IEnumerable<BsItemUsageDto>>(expression);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemUsageDto> dtos = getByIdResponse.Result as IList<BsItemUsageDto>;
                Assert.True(dtos.Count > 0);
            }
        }
    }
}
