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
    public class BSItemLocationServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 304822;
            Expression<Func<BsItemLocationDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSItemLocationService, IEnumerable<BsItemLocationDto>> expression = (x => x.GetBy(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemLocationService, IEnumerable<BsItemLocationDto>>(expression);
           
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemLocationDto> dtos = getByIdResponse.Result as IList<BsItemLocationDto>;
                Assert.True(dtos.Count > 0);
            }
        }
    }
}
