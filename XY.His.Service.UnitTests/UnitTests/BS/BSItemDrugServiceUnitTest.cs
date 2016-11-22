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
    public class BSItemDrugServiceUnitTest : TestBase
    {
        [Fact]
        public void GetByItemId_TestMethod()
        {
            int itemId = 826209;
            Expression<Func<BsItemDrugDto, bool>> query = (x => x.ItemId == itemId);
            Func<IBSItemDrugService, IEnumerable<BsItemDrugDto>> expression = (x => x.Get(query.ToExpressionNode()));
            var getByIdResponse = ServiceProxy.CallService<IBSItemDrugService, IEnumerable<BsItemDrugDto>>(expression);
            
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            //Assert.NotNull(getByIdResponse.Result);
            if (getByIdResponse.Result != null)
            {
                IList<BsItemDrugDto> dtos = getByIdResponse.Result as IList<BsItemDrugDto>;
                Assert.NotNull(dtos);
            }
        }      
    }
}
