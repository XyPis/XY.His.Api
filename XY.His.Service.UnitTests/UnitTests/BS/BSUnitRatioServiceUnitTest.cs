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
    public class BSUnitRatioServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 817200;
            Expression<Func<BsUnitRatioDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSUnitRatioService, IEnumerable<BsUnitRatioDto>> expression = (x => x.GetBy(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSUnitRatioService, IEnumerable<BsUnitRatioDto>>(expression);
           
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsUnitRatioDto> dtos = getByIdResponse.Result as IList<BsUnitRatioDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
