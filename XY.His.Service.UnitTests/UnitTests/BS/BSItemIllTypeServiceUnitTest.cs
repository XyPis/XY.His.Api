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
    public class BSItemIllTypeServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 817200;
            Expression<Func<BsItemIllTypeDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSItemIllTypeService, IEnumerable<BsItemIllTypeDto>> expression = (x => x.GetBy(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemIllTypeService, IEnumerable<BsItemIllTypeDto>>(expression);
         
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemIllTypeDto> dtos = getByIdResponse.Result as IList<BsItemIllTypeDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
