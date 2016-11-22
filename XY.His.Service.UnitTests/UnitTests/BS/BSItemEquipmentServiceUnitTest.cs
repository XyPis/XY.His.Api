using System;
using System.Collections.Generic;
using Xunit;
using XY.His.Client;
using XY.His.Contract.Message;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using System.Linq.Expressions;

namespace XY.His.Service.UnitTests.BS
{
    public class BSItemEquipmentServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemID = 188;
            Expression<Func<BsItemEquipmentDto, bool>> query = (x => x.ItemId == itemID);
            ExpressionNode expressNode = query.ToExpressionNode();
            var getByIdResponse = ServiceProxy.CallService<IBSItemEquipmentService, IEnumerable<BsItemEquipmentDto>>(x => x.Get(expressNode));
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);
            
            if (getByIdResponse.Result != null)
            {
                IList<BsItemEquipmentDto> dtos = getByIdResponse.Result as IList<BsItemEquipmentDto>;
                Assert.NotNull(dtos);
            }
        }
    }
}
