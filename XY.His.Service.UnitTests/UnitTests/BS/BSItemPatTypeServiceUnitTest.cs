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
    public class BSItemPatTypeServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 817200;
            Expression<Func<BsItemPatTypeDto, bool>> query = (x => x.ItemId == itemID);
            Func<IBSItemPatTypeService, IEnumerable<BsItemPatTypeDto>> expression = (x => x.Get(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemPatTypeService, IEnumerable<BsItemPatTypeDto>>(expression);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemPatTypeDto> dtos = getByIdResponse.Result as IList<BsItemPatTypeDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
