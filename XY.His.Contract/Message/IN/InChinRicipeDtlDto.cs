using System;
using System.Collections.Generic;
using XY.His.Contract.Message.RM;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Message.IN
{
    [Serializable]
    public partial class InChinRicipeDtlDto : DtoBase
    {
        public InChinRicipeDtlDto()
        {
            this.RmZyOutDtls = new List<RmZyOutDtlDto>();
        }

        public int RecipeId { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public int UnitTakeId { get; set; }
        public short LsDecoctWay { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItemDto BsItem { get; set; }
        public virtual BsUnitDto BsUnit { get; set; }
        public virtual InChinRicipeDto InChinRicipe { get; set; }
        public virtual ICollection<RmZyOutDtlDto> RmZyOutDtls { get; set; }
    }
}
