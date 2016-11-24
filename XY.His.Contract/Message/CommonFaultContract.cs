using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY.His.Contract.Message
{
    [Serializable]
    public class CommonFaultContract
    {
        public int ErrCode { get; set; }
        public string Message { get; set; }
    }
}
