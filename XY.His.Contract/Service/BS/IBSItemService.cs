using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{ 
    [ServiceContract]
    public interface IBSItemService : IService<BsItemDto>
    {
    }
}
