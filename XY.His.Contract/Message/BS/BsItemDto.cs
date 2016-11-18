using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XY.His.Contract.Message.BS
{
    [Serializable]
    public partial class BsItemDto : DtoBase
    {        
        public short LsGroupType { get; set; }

        
        public string Code { get; set; }
        
        
        public string WbCode { get; set; }

        
        public string PyCode { get; set; }

        
        public string StrokeCode { get; set; }

        
        public string OtherCode { get; set; }

        
        public int GroupMainId { get; set; }

        
        public Nullable<int> GroupSubId { get; set; }

                
        public string Name { get; set; }

        
        public string LongDesc { get; set; }

        
        public string EngDesc { get; set; }

        
        public string Spec { get; set; }

        
        public int UnitInId { get; set; }

        
        public decimal PriceIn { get; set; }

        
        public int UnitDiagId { get; set; }

        
        public decimal PriceDiag { get; set; }

        
        public decimal AddPercent { get; set; }

        
        public short LsRpType { get; set; }

        
        public decimal Dosage { get; set; }

        
        public Nullable<int> UnitTakeId { get; set; }

        
        public Nullable<int> FrequencyId { get; set; }

        
        public Nullable<int> UsageId { get; set; }

        
        public int FeeMzId { get; set; }

        
        public int FeeZyId { get; set; }

        
        public short LsGfType { get; set; }

        
        public Nullable<decimal> GfFixDisc { get; set; }

        
        public bool OptionPrice { get; set; }

        
        public decimal LimitTotalMz { get; set; }

        
        public decimal LimitTotalZy { get; set; }

        
        public int TypeGFXEId { get; set; }

        
        public bool IsSpecSum { get; set; }

        
        public bool IsNew { get; set; }

        
        public bool IsOnlyForSys { get; set; }

        
        public bool IsRpForbid { get; set; }

        
        public bool IsChildAdd { get; set; }

        
        public bool IsBedFee { get; set; }

        
        public bool IsOpsAdd { get; set; }

        
        public short LsfeeTurn { get; set; }

        
        public short LsAdviceType { get; set; }

        
        public Nullable<int> LocationId { get; set; }

        
        public Nullable<int> LISCode { get; set; }

        
        public string CoverPicture { get; set; }

        
        public string MemoPicture { get; set; }

        
        public string Memo { get; set; }

        
        public bool IsActive { get; set; }

        
        public string F1 { get; set; }

        
        public string F2 { get; set; }

        
        public string F3 { get; set; }

        
        public string F4 { get; set; }

        
        public short IconIndex { get; set; }

        
        public Nullable<bool> IsInoculate { get; set; }

        
        public Nullable<decimal> PriceHighLine { get; set; }

        
        public Nullable<short> OrderBy { get; set; }

        
        public Nullable<int> GroupSubId2 { get; set; }

        
        public Nullable<System.DateTime> LastTime { get; set; }

        
        public Nullable<decimal> PriceSub { get; set; }

        
        public Nullable<int> CheckId { get; set; }

        
        public Nullable<int> NurseId { get; set; }

        
        public Nullable<int> CureId { get; set; }

        
        public Nullable<int> DrugID { get; set; }

        
        public Nullable<int> CopyId { get; set; }

        
        public Nullable<int> MzUnitTotal { get; set; }

        
        public Nullable<int> ZyUnitTotal { get; set; }

        
        public Nullable<bool> IsMtDrug { get; set; }

        
        public string PackageSpec { get; set; }

        
        public bool IsCitySum { get; set; }

        
        public virtual BsFrequencyDto BsFrequency { get; set; }

        
        public virtual BsGfxeDto BsGfxe { get; set; }

        
        public virtual BsGroupDto BsGroup { get; set; }

        
        public virtual BsGroupSubDto BsGroupSub { get; set; }

        
        public virtual BsLocationDto BsLocation { get; set; }

        
        public virtual BsMzFeetyDto BsMzFeety { get; set; }

        
        public virtual BsUnitDto BsUnit { get; set; }

        
        public virtual BsUnitDto BsUnit1 { get; set; }

        
        public virtual BsUnitDto BsUnit2 { get; set; }

        
        public virtual BsUsageDto BsUsage { get; set; }
        
        
        public virtual BsZyFeetyDto BsZyFeety { get; set; }
        
    }
}
