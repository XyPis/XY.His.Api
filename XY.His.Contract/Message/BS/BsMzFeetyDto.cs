using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XY.His.Contract.Message.BS
{
    [Serializable]
    public partial class BsMzFeetyDto : DtoBase
    {
        public string Code { get; set; }

        
        public string Name { get; set; }

        
        public Nullable<int> InvItemId { get; set; }

        
        public string WbCode { get; set; }

        
        public string PyCode { get; set; }

        
        public Nullable<int> LocationId { get; set; }

        
        public bool IsActive { get; set; }

        
        public short OrderBy { get; set; }

        
        public string F1 { get; set; }

        
        public string F2 { get; set; }

        
        public string F3 { get; set; }

        
        public string F4 { get; set; }

        
        public short IconIndex { get; set; }

        
        public virtual BsLocationDto BsLocation { get; set; }

        
        public virtual BsInvMzItemDto BsInvMzItem { get; set; }
    }
}
