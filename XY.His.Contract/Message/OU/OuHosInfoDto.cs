using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.OU
{
    [Serializable]
    public partial class OuHosInfoDto : DtoBase
    {
        public string MzRegNo { get; set; }
        public System.DateTime RegTime { get; set; }
        public int PatId { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public bool IsBaby { get; set; }
        public Nullable<short> AgeDay { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public int PatTypeId { get; set; }
        public string MedicareNo { get; set; }
        public int RegTypeId { get; set; }
        public bool IsPriority { get; set; }
        public bool IsElder { get; set; }
        public int LineOrder { get; set; }
        public decimal RegFee { get; set; }
        public decimal ZyFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public decimal PaySel { get; set; }
        public decimal TallyDiag { get; set; }
        public decimal FactGet { get; set; }
        public int RegDept { get; set; }
        public Nullable<int> DiagnDept { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string RoomNo { get; set; }
        public bool IsFreeDiag { get; set; }
        public bool IsFreeReg { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsPreReg { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> TimeSpanId { get; set; }
        public string RegDate { get; set; }
        public Nullable<byte> Age { get; set; }
        public string AgeString { get; set; }
        public string ContactPhone { get; set; }
        public string LinkmanName { get; set; }
        public Nullable<System.DateTime> TallyTime { get; set; }
        public Nullable<System.DateTime> CancelTallyTime { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public Nullable<int> TimeSpanSubId { get; set; }
        public Nullable<int> DiagRoomId { get; set; }
        public Nullable<int> CallDoctorId { get; set; }
        public Nullable<int> CallOrder { get; set; }
        public Nullable<bool> IsFirstCheck { get; set; }
        public Nullable<bool> IsGoodRecipe { get; set; }
        public string GoodRecipe { get; set; }       
    }
}
