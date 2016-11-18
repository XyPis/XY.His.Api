using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace XY.His.Contract.Message.Gbl
{
    [Serializable]    
    public partial class GblSettingDto : DtoBase
    {
        
        public string KeyNum { get; set; }

        
        public string SetValue { get; set; }

        
        public string F1 { get; set; }

        
        public string F2 { get; set; }

        
        public string F3 { get; set; }

        
        public string F4 { get; set; }
    }
}
