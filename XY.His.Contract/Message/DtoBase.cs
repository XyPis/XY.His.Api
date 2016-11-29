using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace XY.His.Contract.Message
{        
    [Serializable]
    public abstract class DtoBase
    {        
        public int ID { get; set; }
    }
}
