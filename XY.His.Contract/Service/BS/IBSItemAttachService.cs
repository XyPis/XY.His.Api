using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{
    public interface IBSItemAttachService : IService<BsItemAttachDto>
    {
        IEnumerable<BsItemAttachDto> GetByItemId(int itemId);
    }
}
