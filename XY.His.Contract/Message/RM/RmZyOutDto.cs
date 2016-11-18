using System;
using System.Collections.Generic;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Message.RM
{
    [Serializable]
    public partial class RmZyOutDto : DtoBase
    {
        public RmZyOutDto()
        {
            this.RmZyOutDtls = new List<RmZyOutDtlDto>();
        }

        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsRoomDto BsRoom { get; set; }
        public virtual ICollection<RmZyOutDtlDto> RmZyOutDtls { get; set; }
    }
}
